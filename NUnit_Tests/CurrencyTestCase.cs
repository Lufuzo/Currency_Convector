using Currency_Convector.Contract;
using Currency_Convector.Service;
using Microsoft.VisualBasic;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnit_Tests
{
    [TestFixture]
    public class CurrencyTestCase
    {
        private ExchangeRateService service;

        [SetUp]
        public void Setup()
        {
            service = new ExchangeRateService();
        }

        [Test]
        public void GetExchangeRate_PositiveTest()
        {
            string baseCurrency = "USD";
            string targetCurrency = "EUR";

            // Act
            decimal exchangeRate =  service.GetExchangeRate(baseCurrency, targetCurrency);

            // Assert
            Assert.AreEqual(0.85m, exchangeRate, "Exchange rate is not correct");
        }
        [Test]
        public void GetSortedRates_SortDescending_ReturnsSortedRates()
        {
            // Arrange
            dynamic rates = new
            {
                EUR = 0.9m,
                GBP = 0.7m,
                JPY = 110.5m
            };

            // Act
            var sortedRates = service.GetSortedRates(rates);

            // Assert
            Assert.AreEqual("JPY", sortedRates[0].Key);
            
        }
    }
}
