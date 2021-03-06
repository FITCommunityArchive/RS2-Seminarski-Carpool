﻿using Carpool.Model;
using Stripe;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace eProdaja.MobileApp.ViewModels
{
    public class PaymentViewModel : BaseViewModel
    {
        private readonly APIService _automobili = new APIService("Automobil");
        private readonly APIService _voznja = new APIService("Voznja");
        public PaymentViewModel()
        {
            InitCommand = new Command(async (param) => await Init((int)param));
            PayCommand = new Command(async () => await Pay());
        }

        public int voznjaID;

        public DateTime _minDatum = DateTime.Now;
        public DateTime MinDatum
        {
            get { return _minDatum; }
            set { SetProperty(ref _minDatum, value); }
        }


        public byte[] _slika = null;
        public byte[] Slika
        {
            get { return _slika; }
            set { SetProperty(ref _slika, value); }
        }

        public string _korisnickoIme = null;
        public string KorisnickoIme
        {
            get { return _korisnickoIme; }
            set { SetProperty(ref _korisnickoIme, value); }
        }
        public string _gradPolaska = null;
        public string GradPolaska
        {
            get { return _gradPolaska; }
            set { SetProperty(ref _gradPolaska, value); }
        }
        public string _gradDestinacija = null;
        public string GradDestinacija
        {
            get { return _gradDestinacija; }
            set { SetProperty(ref _gradDestinacija, value); }
        }
        public string _punaCijenaPrikaz = null;
        public string PunaCijenaPrikaz
        {
            get { return _punaCijenaPrikaz; }
            set { SetProperty(ref _punaCijenaPrikaz, value); }
        }

        //stripe
        
        public string _creditCardNumber = null;
        public string CreditCardNumber
        {
            get { return _creditCardNumber; }
            set { SetProperty(ref _creditCardNumber, value); }
        }

        public string _expiryYear = null;
        public string ExpiryYear
        {
            get { return _expiryYear; }
            set { SetProperty(ref _expiryYear, value); }
        } 
        public string _expiryMonth = null;
        public string ExpiryMonth
        {
            get { return _expiryMonth; }
            set { SetProperty(ref _expiryMonth, value); }
        }
        public string _cvc = null;
        public string CVC
        {
            get { return _cvc; }
            set { SetProperty(ref _cvc, value); }
        }

        public decimal _punaCijena;
        public decimal PunaCijena
        {
            get { return _punaCijena; }
            set { SetProperty(ref _punaCijena, value); }
        }

        public ICommand InitCommand { get; set; }
        public ICommand PayCommand { get; set; }

        public bool Validate()
        {

            if (string.IsNullOrWhiteSpace(CreditCardNumber) || string.IsNullOrWhiteSpace(ExpiryYear) ||
                string.IsNullOrWhiteSpace(ExpiryMonth) || string.IsNullOrWhiteSpace(CVC))
            {
                Xamarin.Forms.Application.Current.MainPage.DisplayAlert("Carpool", "Popunite sva polja!", "OK");
                return false;
            }
            else if (CreditCardNumber.Length != 16)
            {
                Xamarin.Forms.Application.Current.MainPage.DisplayAlert("Carpool", "Broj kreditne kartice mora sadržavati 16 cifara!", "OK");
                return false;
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(CreditCardNumber, "^[0-9]*$"))
            {
                Xamarin.Forms.Application.Current.MainPage.DisplayAlert("Carpool", "Broj kreditne kartice sadrži samo brojeve!", "OK");
                return false;
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(ExpiryYear, "^[0-9]*$"))
            {
                Xamarin.Forms.Application.Current.MainPage.DisplayAlert("Carpool", "Godina sadrži samo brojeve!", "OK");
                return false;
            }
            else if (ExpiryYear.Length != 4)
            {
                Xamarin.Forms.Application.Current.MainPage.DisplayAlert("Greška", "Godina mora sadržavati 4 broja", "OK");
                return false;
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(ExpiryMonth, "^[0-9]*$"))
            {
                Xamarin.Forms.Application.Current.MainPage.DisplayAlert("Carpool", "Mjesec sadrži samo brojeve!", "OK");
                return false;
            }
            else if (ExpiryMonth.Length < 1 || ExpiryMonth.Length > 2)
            {
                Xamarin.Forms.Application.Current.MainPage.DisplayAlert("Carpool", "Unesite validan mjesec!", "OK");
                return false;
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(CVC, "^[0-9]*$"))
            {
                Xamarin.Forms.Application.Current.MainPage.DisplayAlert("Carpool", "CVC sadrži samo brojeve!", "OK");
                return false;
            }
            else if (CVC.Length != 3)
            {
                Xamarin.Forms.Application.Current.MainPage.DisplayAlert("Carpool", "CVC sadrži tri cifre!", "OK");
                return false;
            }
            else
            {
                return true;
            }
        }

        public async Task Pay()
        {
                try
                {
                    var stripeTokenId = CreateToken(CreditCardNumber, ExpiryMonth, ExpiryYear, CVC);
                    var payment = await _voznja.Payment(new PaymentModel()
                    {
                        Amount = _punaCijena,
                        Token = stripeTokenId
                    });

                    await Xamarin.Forms.Application.Current.MainPage.DisplayAlert("Carpool", "Uspješna transakcija", "OK");
                    await Xamarin.Forms.Application.Current.MainPage.Navigation.PopModalAsync();
                    await Xamarin.Forms.Application.Current.MainPage.Navigation.PopAsync();
                }
                catch (Exception ex)
                {
                    await Xamarin.Forms.Application.Current.MainPage.DisplayAlert("Carpool", ex.Message, "OK");
                }         
        }

        public string CreateToken(string cardNumber, string cardExpMonth, string cardExpYear, string cardCVC)
        {
            StripeConfiguration.ApiKey = "pk_test_T1hPIaTkyJZX4kmDcP20jlEm009wuJq7qo";

            var options = new TokenCreateOptions
            {
                Card = new CreditCardOptions
                {
                    Number = cardNumber,
                    ExpYear = long.Parse(cardExpYear),
                    ExpMonth = long.Parse(cardExpMonth),
                    Cvc = cardCVC
                }
            };

            var service = new TokenService();
            Token stripeToken = service.Create(options);

            return stripeToken.Id; // This is the token
        }

        public async Task Init(int voznjaId)
        {
            try
            {
                var v = await _voznja.GetById<Voznja>(voznjaId);

                var auto = await _automobili.GetById<Automobil>(v.AutomobilID);
                Slika = auto.Slika;

                KorisnickoIme = v.KorisnickoIme;
                GradPolaska = v.GradPolaska;
                GradDestinacija = v.GradDestinacija;

                PunaCijena = v.PunaCijena;

                PunaCijenaPrikaz = v.PunaCijenaPrikaz;


                voznjaID = v.VoznjaID;
        
            }
            catch (Exception)
            {

            }
        }
    }
}
