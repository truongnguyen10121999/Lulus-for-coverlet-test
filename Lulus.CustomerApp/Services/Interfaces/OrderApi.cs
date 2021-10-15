using Lulus.ViewModels.Order;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Lulus.CustomerApp.Services.Interfaces
{
    public class OrderApi : IOrderApi
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public OrderApi(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<string> AddProduct(AddProductToCartRequest request)
        {
            var json = JsonConvert.SerializeObject(request);
            var httpcontent = new StringContent(json, Encoding.UTF8, "application/json");

            var client = _httpClientFactory.CreateClient();
            client.BaseAddress = new Uri("https://localhost:44354");
            var respond = await client.PostAsync("/api/Order/AddProduct",httpcontent);
            var body = await respond.Content.ReadAsStringAsync();
            if (respond.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<string>(body);
            }

            return "";
        }

        public async Task<CurrentCartRespond> GetCurrentCart(Guid userID)
        {
            var json = JsonConvert.SerializeObject(userID);

            var client = _httpClientFactory.CreateClient();
            client.BaseAddress = new Uri("https://localhost:44354");
            var respond = await client.GetAsync("/api/Order/GetCurrentCart/"+userID);
            var body = await respond.Content.ReadAsStringAsync();
            if (respond.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<CurrentCartRespond>(body);
            }

            return new CurrentCartRespond();
        }
    }
}
