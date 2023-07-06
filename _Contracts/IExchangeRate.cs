using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Contracts
{
    public interface IExchangeRate
    {
        decimal GetExchangeRate(string baseCurrency, string targetCurrency);
    }
}
