using System;
using System.Collections.Generic;
using System.Text;

namespace ExchangeRateAppLibrary
{
    public class CurrencyPair
    {
        public string Name { get; set; }
        public double CurrentPrice { get; set; }
        public double PreviousPrice { get; set; }
        
        public string BullBearImgUrl { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }


    public class Trade
    {
        public string CurrencyPair { get; set; }
        public string BuySell { get; set; }
        public double LotSize { get; set; }
        public double Result { get; set; }

        public double EntryPrice { get; set; }

        public double CurrentPrice { get; set; }

        public override string ToString()
        {
            return CurrencyPair;
        }
    }
}


