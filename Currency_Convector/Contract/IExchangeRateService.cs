using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Currency_Convector.Contract
{
    public interface IExchangeRateService
    {
        decimal GetExchangeRate(string baseCurrency, string targetCurrency);
    }
}
