using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Currency_Converter
{
    internal static class CurrenciesHelper
    {

        public static Currencies GetCurrencyEnum(string currency)
        {
            switch (currency)
            {
                case "GBP":
                    return Currencies.GBP;
                case "EUR":
                    return Currencies.EUR;
                case "USD":
                    return Currencies.USD;
                case "BTC":
                    return Currencies.BTC;
                case "ETH":
                    return Currencies.ETH;
                case "LTC":
                    return Currencies.LTC;
                default:
                    throw new ArgumentException();
            }
        }
    }
}
