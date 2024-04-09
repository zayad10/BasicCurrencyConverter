using System;
using System.Windows.Forms;
using System.Net;
using Newtonsoft.Json.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Simple_Currency_Converter
{
    public partial class Form1 : Form
    {
        private int convertToCurrency = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            fromCurrencyBox.SelectedItem = "GBP";
        }

        private double GetExchangeRate(string fromCurrency, string toCurrency)
        {
            this.convertToCurrency = (int)CurrenciesHelper.GetCurrencyEnum(toCurrency);
            string json;
            var rate = 0.00;
            using (var client = new WebClient())
            {
                if (convertToCurrency < 2)
                {
                    json = client.DownloadString($"https://open.er-api.com/v6/latest/{fromCurrency}");

                    var data = JObject.Parse(json);
                    rate = (double)data["rates"][toCurrency];
                }
                else 
                {
                    json = client.DownloadString($"https://api.coinbase.com/v2/prices/{fromCurrency}-{toCurrency}/buy");

                    var data = JObject.Parse(json);
                    rate = (double)data["data"]["amount"];
                }
            }

            return rate;
        }

        private void fromCurrencyBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            string fromCurrency = fromCurrencyBox.SelectedItem.ToString();
            string toCurrency = toCurrencyBox.SelectedItem.ToString();

            double amount;
            if (!double.TryParse(amountInput.Text, out amount))
            {
                MessageBox.Show("Please enter a valid numeric amount to convert.", "Error", MessageBoxButtons.OK);
                return;
            }

            double exchangeRate;
            try
            {
                exchangeRate = GetExchangeRate(fromCurrency, toCurrency);
            }
            catch (Exception ex) 
            {
                MessageBox.Show("An error has occurred retrieving the exchange rate!", "Error - API", MessageBoxButtons.OK);
                return;
            }

            double convertedAmount = amount * exchangeRate;
            convertedAmountLabel.Text = $"Converted Amount:  {toCurrency + " " + (convertToCurrency > 2 ? convertedAmount.ToString("F6") : convertedAmount.ToString("F2"))}";
            conversionRateLabel.Text = $"Conversion Rate: 1 {fromCurrency} = {1 * exchangeRate} {toCurrency}";
        }
    }
}
