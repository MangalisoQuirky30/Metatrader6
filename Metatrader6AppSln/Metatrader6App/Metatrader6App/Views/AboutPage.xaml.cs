using ExchangeRateAppLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Metatrader6App.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class AboutPage : ContentPage
    {
      
        public List<CurrencyPair> CurrencyPairs { get; set; }

        public AboutPage()
        {
            InitializeComponent();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();

            ExchangeRatesGenerator rates = new ExchangeRatesGenerator();
            double usdzar = await rates.USDZARAsync() ;
            double usdjpy = await rates.USDJPYAsync();
            double usdchf = await rates.USDCHFAsync();
            double usdcad = await rates.USDCADAsync();

            CurrencyPairs  = new List<CurrencyPair>();

            CurrencyPairs.Add(new CurrencyPair
            {
                Name = "USDZAR",
                CurrentPrice = usdzar,
                PreviousPrice = 0,
                BullBearImgUrl = "upwardarrow.png"
            });

            CurrencyPairs.Add(new CurrencyPair
            {
                Name = "USDJPY",
                CurrentPrice = usdjpy - 0.000009,
                PreviousPrice = 0,
                BullBearImgUrl = "downwardarrow.png"
            });

            CurrencyPairs.Add(new CurrencyPair
            {
                Name = "USDCHF",
                CurrentPrice = usdchf,
                PreviousPrice = 0,
                BullBearImgUrl = "downwardarrow.png"
            });

            CurrencyPairs.Add(new CurrencyPair
            {
                Name = "USDCAD",
                CurrentPrice = usdcad,
                PreviousPrice = 0,
                BullBearImgUrl = "upwardarrow.png"
            });

            BindingContext = this;

        }
    }
}