using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ExchangeRateAppLibrary
{
    public class ExchangeRatesGenerator
    {
        public async Task<double> USDZARAsync()
        {
            HttpClient client = new HttpClient();
            string quotesStr = await client.GetStringAsync("https://openexchangerates.org/api/latest.json?app_id=57c57c44aadc495dae7c6e8faa5c2666&base=USD");

            GetQuotes usdData = JsonConvert.DeserializeObject<GetQuotes>(quotesStr);

            double data = usdData.rates.ZAR;

            return data;
        }

        public async Task<double> USDJPYAsync()
        {
            HttpClient client = new HttpClient();
            string quotesStr = await client.GetStringAsync("https://openexchangerates.org/api/latest.json?app_id=57c57c44aadc495dae7c6e8faa5c2666&base=USD");

            GetQuotes usdData = JsonConvert.DeserializeObject<GetQuotes>(quotesStr);

            double data = usdData.rates.JPY;

            return data;
        }

        public async Task<double> USDCHFAsync()
        {
            HttpClient client = new HttpClient();
            string quotesStr = await client.GetStringAsync("https://openexchangerates.org/api/latest.json?app_id=57c57c44aadc495dae7c6e8faa5c2666&base=USD");

            GetQuotes usdData = JsonConvert.DeserializeObject<GetQuotes>(quotesStr);

            double data = usdData.rates.CHF;

            return data;
        }

        public async Task<double> USDCADAsync()
        {
            HttpClient client = new HttpClient();
            string quotesStr = await client.GetStringAsync("https://openexchangerates.org/api/latest.json?app_id=57c57c44aadc495dae7c6e8faa5c2666&base=USD");

            GetQuotes usdData = JsonConvert.DeserializeObject<GetQuotes>(quotesStr);

            double data = usdData.rates.CAD;

            return data;
        }


    }
}




           