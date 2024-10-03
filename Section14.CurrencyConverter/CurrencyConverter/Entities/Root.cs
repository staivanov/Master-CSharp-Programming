using Newtonsoft.Json;
using System.Data;
using System.Net;
using System.Net.Http;
using System.Windows;

namespace Section14.CurrencyConverter.Entities
{
    public class Root
    {
        public Rate rates { get; set; }
        public long timestamp;
        public string license;


        private async void GetValue()
        {
            string url = $"https://openexchangerates.org/api/latest.json?app_id=7efb0474f3d949038f4573d36b20a185";
            Root val = await GetData<Root>(url);
            BindCurrency();
        }

        private void BindCurrency()
        {
            DataTable dtCurrency = new();
            dtCurrency.Rows.Add("Text");
            dtCurrency.Rows.Add("Value");
        }

        public static async Task<Root> GetData<T>(string url)
        {
            Root myRoot = new();

            try
            { //Provides a bae class for HTTP requests.
                HttpClient client = new();

                using (client)
                {
                    client.Timeout = TimeSpan.FromMinutes(1);
                    HttpResponseMessage httpResponse = await client.GetAsync(url);

                    if (httpResponse.StatusCode == HttpStatusCode.OK)
                    {
                        string responseString = await httpResponse.Content.ReadAsStringAsync();
                        Root? responseObject = JsonConvert.DeserializeObject<Root>(responseString);

                        MessageBox.Show("TimeStamp: " + responseObject.timestamp,
                                                        "Information", MessageBoxButton.OK,
                                                        MessageBoxImage.Information);

                        return responseObject; //Return API response.
                    }

                    return myRoot;
                }
            }
            catch (Exception)
            {
                return myRoot;
            }
        }
    }
}
