using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using Metatrader6App.Models;
using Metatrader6App.Views;
using Metatrader6App.ViewModels;
using ExchangeRateAppLibrary;

namespace Metatrader6App.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class ItemsPage : ContentPage
    {
   //     ItemsViewModel viewModel;

        public IList<Trade> Trades { get; set; }

        public ItemsPage()
        {
            InitializeComponent();

         //   BindingContext = viewModel = new ItemsViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            Trades = new List<Trade>();

            Trades.Add(new Trade
            {
                CurrencyPair = "USDZAR",
                BuySell = "BUY",
                LotSize = 0.01,
                Result = 3242,
                EntryPrice = 1.31003,
                CurrentPrice = 65322.43
            });


            BindingContext = this;

        }
    }
}