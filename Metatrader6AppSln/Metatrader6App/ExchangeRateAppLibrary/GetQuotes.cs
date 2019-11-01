using System;
using System.Collections.Generic;
using System.Text;

namespace ExchangeRateAppLibrary
{
    public class Rates
    {
        
        public double CAD { get; set; }
        public double CHF { get; set; }
        public double GBP { get; set; }
        public double JPY { get; set; }
        public double SZL { get; set; }
        public double ZAR { get; set; }
    }

    public class GetQuotes
    {
        public string disclaimer { get; set; }
        public string license { get; set; }
        public int timestamp { get; set; }
        public string @base { get; set; }
        public Rates rates { get; set; }
    }
}
