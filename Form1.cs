using System;
using System.Windows.Forms;
using System.Net;
using Newtonsoft.Json.Linq;

namespace Simple_Currency_Converter
{
    public partial class Form1 : Form
    {
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
            string json;

            using (var client = new WebClient())
            {
                json = client.DownloadString($"https://open.er-api.com/v6/latest/{fromCurrency}");
            }

            var data = JObject.Parse(json);
            var rate = (double)data["rates"][toCurrency];

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
            convertedAmountLabel.Text = $"Converted Amount:  {toCurrency + " " + convertedAmount.ToString("F2")}";
            conversionRateLabel.Text = $"Conversion Rate: 1 {fromCurrency} = {1 * exchangeRate} {toCurrency}";
        }
    }
}
