using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http.Headers;

namespace BusinessLogic
{
    public class CryptoService
    {
        private readonly HttpClient _httpClient;
        private string apiKey = "9ca43cc8-c5fd-4049-9bb3-3df4de6d2e74";

        public CryptoService()
        {
            _httpClient = new HttpClient();
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", apiKey);
        }

        public async Task<List<CryptoService>> GetTop100TrendingCryptocurrencies()
        {
            var url = "https://pro-cap/coinmarketcap.com/v1/cryptocurrency/quote/latest?limit=100";

            var response = await _httpClient.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                var jsonString = await response.Content.ReadAsStringAsync();
            }
            return null;
        }
    }
}
