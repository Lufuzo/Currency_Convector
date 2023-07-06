using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Services
{
    public class ExchangeRateService
    {
        private Dictionary<string, decimal> exchangeRates;

        public ExchangeRateService()
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

        public List<KeyValuePair<string, decimal>> GetSortedRates(Dictionary<string, decimal> rates)
        {
            List<KeyValuePair<string, decimal>> sortedRates = rates.ToList();

            sortedRates.Sort((pair1, pair2) => pair2.Value.CompareTo(pair1.Value));

            return sortedRates;
        }


        public void DisplayTop10MostValuableCurrencies(Dictionary<string, decimal> rates)
        {
            List<KeyValuePair<string, decimal>> sortedRates = GetSortedRates(rates);

            int count = Math.Min(sortedRates.Count, 10);

            Console.WriteLine("Top 10 Most Valuable Currencies:");
            for (int i = 0; i < count; i++)
            {
                KeyValuePair<string, decimal> rate = sortedRates[i];
                Console.WriteLine($"{rate.Key}: {rate.Value}");
            }
        }


    }
}
