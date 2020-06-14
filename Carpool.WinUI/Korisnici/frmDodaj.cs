﻿using Carpool.Model.Requests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Carpool.WinUI.Korisnici
{
    public partial class frmDodaj : Form
    {
        private readonly APIService _apiService = new APIService("korisnik");
        private readonly APIService _ulogeService = new APIService("Uloga");

        private int? _id = null;
        public frmDodaj(int? korisnikId = null)
        {
            InitializeComponent();
            _id = korisnikId;
        }

        private async void btnSpremi_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {

                var roleList = clbUloge.CheckedItems.Cast<Model.Uloge>().Select(x => x.UlogaId).ToList();

                var request = new KorisnikInsertRequest()
                {
                    Email = txtEmail.Text,
                    BrojTelefona = txtTelefon.Text,
                    Ime = txtIme.Text,
                    Prezime = txtPrezime.Text,
                    KorisnickoIme = txtKorisnickoIme.Text,
                    Password = txtPassword.Text,
                    PasswordConfirmation = txtPasswordPotvrda.Text,
                    Uloge = roleList
                };

                if (_id.HasValue)
                {
                    await _apiService.Update<Model.Korisnik>(_id.Value, request);
                }
                else
                {
                    await _apiService.Insert<Model.Korisnik>(request);
                }

                MessageBox.Show("Operacija uspješna");
            }
        }

        private async void frmDodaj_Load(object sender, EventArgs e)
        {
            if (_id.HasValue)
            {
                var korisnik = await _apiService.GetById<Model.Korisnik>(_id);

                txtIme.Text = korisnik.Ime;
                txtPrezime.Text = korisnik.Prezime;
                txtEmail.Text = korisnik.Email;
                txtKorisnickoIme.Text = korisnik.KorisnickoIme;
                txtTelefon.Text = korisnik.BrojTelefona;
            }

            await LoadUloge();
        }

        private async Task LoadUloge()
        {
            var ulogeList = await _ulogeService.Get<List<Model.Uloge>>(null);

            clbUloge.DataSource = ulogeList;
            clbUloge.DisplayMember = "Naziv";
        }

        private void txtIme_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIme.Text))
            {
                errorProvider.SetError(txtIme, Properties.Resources.Validation_RequiredField);
            }
            else
            {
                errorProvider.SetError(txtIme, null);
            }
        }

        private void txtPrezime_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPrezime.Text))
            {
                errorProvider.SetError(txtPrezime, Properties.Resources.Validation_RequiredField);
            }
            else
            {
                errorProvider.SetError(txtPrezime, null);
            }
        }

        private void txtTelefon_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTelefon.Text))
            {
                errorProvider.SetError(txtTelefon, Properties.Resources.Validation_RequiredField);
            }
            else
            {
                errorProvider.SetError(txtTelefon, null);
            }
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                errorProvider.SetError(txtEmail, Properties.Resources.Validation_RequiredField);
            }
            else
            {
                errorProvider.SetError(txtEmail, null);
            }
        }

        private void txtKorisnickoIme_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtKorisnickoIme.Text) && txtKorisnickoIme.Text.Length < 3)
            {
                errorProvider.SetError(txtKorisnickoIme, Properties.Resources.Validation_RequiredField);
            }
            else
            {
                errorProvider.SetError(txtKorisnickoIme, null);
            }
        }
    }
}