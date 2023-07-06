using _Entities;
using _Services;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Currency_Convector
{
    public partial class frmCurrency : Form
    {
        private ExchangeRateService service;
        public frmCurrency()
        {
            InitializeComponent();
            service = new ExchangeRateService();
        }

        double amount = 0.0;
        string outputCurrency = string.Empty;
        ExchangeRates rates = new ExchangeRates();
        static readonly string baseCurrency = "ZAR";
        private async void Form1_Load(object sender, EventArgs e)
        {

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    string url = $"https://api.exchangerate-api.com/v4/latest/{baseCurrency}";

                    HttpResponseMessage response = await client.GetAsync(url);

                    if (response.IsSuccessStatusCode)
                    {
                        string json = await response.Content.ReadAsStringAsync();
                        dynamic data = JsonConvert.DeserializeObject(json);

                        // Display conversion rates
                     
                        Console.WriteLine("Conversion rates:");
                        foreach (var rate in data.rates)
                        {
                            lstvCurrrency.View = View.Details; 
                            ListViewItem item = lstvCurrrency.Items.Add(rate.Name);
                            item.SubItems.Add(string.Empty); 
                            item.SubItems[1].Text = rate.Value;

                          

                        }

                        // Display top 10 most valuable currencies
                        Console.WriteLine("\nTop 10 most valuable currencies:");
                        var sortedRates = service.GetSortedRates(data.rates);
                        int count = 0;

                        foreach (var rate in sortedRates)
                        {

                         
                            lstvCurrrency.Items.Add("Top 10"+ " "+$"{rate.Name}: {rate.Value}");
                            count++;
                            if (count >= 10)
                                break;
                        }
                    }
                    else
                    {
                        lblError.Text = ("Failed to retrieve exchange rates. Status code: " + response.StatusCode);
                        lblError.Visible = true;
                    }
                }
                catch (Exception ex)
                {
                 Console.WriteLine("An error occurred: " + ex.Message);
  
                }
            }
          
          
          
        }

        static ExchangeRates GetExchangeRates(string baseCurrency)
        {
            using (WebClient client = new WebClient())
            {
                string url = $"https://api.exchangerate-api.com/v4/latest/{baseCurrency}";
                string json = client.DownloadString(url);
                return JsonConvert.DeserializeObject<ExchangeRates>(json);
            }
        }

        static double ConvertCurrency(double amount, Rates rates, string outputCurrency, double val)
        {
            if (outputCurrency != string.Empty)
            {
                //double rate = rates[outputCurrency];
                double rate = val;
                return amount * rate;
            }
            else
            {
                throw new ArgumentException("Invalid output currency");
            }
        }

        private void btnConvect_Click(object sender, EventArgs e)
        {

            amount = double.Parse(txtCurrencyAmount.Text);

            double currencyVal = double.Parse(txtCurrencyAmount.Text);
            outputCurrency = txtCurrency.Text.ToUpper();


            double convertedAmount = ConvertCurrency(amount, rates.Rates, outputCurrency, currencyVal);
            txtConvectedAmount.Text = convertedAmount.ToString();
        }

        private void lstvCurrrency_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstvCurrrency.SelectedItems.Count > 0)
            {
                ListViewItem item = lstvCurrrency.SelectedItems[0];
                txtCurrency.Text = item.SubItems[0].Text;
                txtCurrencyAmount.Text = item.SubItems[1].Text;
            }
           
         
        }

        private void btnClear_Click(object sender, EventArgs e)
        {

            txtAmountToConvect.Text = string.Empty;
            txtConvectedAmount.Text= string.Empty;
            txtCurrency.Text = string.Empty;
            txtCurrencyAmount.Text= string.Empty;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
       
            this.Close();
        }
    }
}
