using _Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Repository
{
    public class ExchangeRateRepo : IExchangeRate
    {
        private Dictionary<string, decimal> exchangeRates;


        public ExchangeRateRepo()
        {
            // Initialize exchange rates
            exchangeRates = new Dictionary<string, decimal>
        {
            { "USD", 1.0m },   // US Dollar
            { "EUR", 0.85m },  // Euro
            { "GBP", 0.72m },  // British Pound
            { "JPY", 110.0m }, // Japanese Yen
         
        };
        }
        public decimal GetExchangeRate(string baseCurrency, string targetCurrency)
        {
            if (!exchangeRates.ContainsKey(baseCurrency))
            {
                throw new ArgumentException($"Unsupported base currency: {baseCurrency}");
            }

            if (!exchangeRates.ContainsKey(targetCurrency))
            {
                throw new ArgumentException($"Unsupported target currency: {targetCurrency}");
            }

            decimal baseRate = exchangeRates[baseCurrency];
            decimal targetRate = exchangeRates[targetCurrency];

            return targetRate / baseRate;
        }
    }
}
