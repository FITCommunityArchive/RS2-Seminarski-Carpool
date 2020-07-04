﻿using eProdaja.MobileApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace eProdaja.MobileApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NewsPage : ContentPage
    {
        NewsViewModel model = null;
        public NewsPage()
        {
            InitializeComponent();
            BindingContext = model = new NewsViewModel();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
        }

        private async void NewsClicked(object sender, SelectedItemChangedEventArgs e)
        {
            if (model.MojeObavijestiBool){
                await Navigation.PushAsync(new AddNewsPage(((Carpool.Model.Obavijesti)e.SelectedItem).ObavijestiID));
            }  
        }
    }
}