using Lulus.CustomerApp.Infrastructures.User;
using Lulus.CustomerApp.Services.Interfaces;
using Lulus.ViewModels.Order;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Lulus.CustomerApp.Services
{
    public class OrderApi : IOrderApi
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly UserSingleton _userSingleton;
        public OrderApi(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
            _userSingleton = UserSingleton.GetInstance();
        }
        public async Task<string> AddProduct(AddProductToCartRequest request)
        {
            var json = JsonConvert.SerializeObject(request);
            var httpcontent = new StringContent(json, Encoding.UTF8, "application/json");

            var client = _httpClientFactory.CreateClient();
            client.BaseAddress = new Uri("https://localhost:44354");
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _userSingleton.GetToken());
            var respond = await client.PostAsync("/api/Order/AddProduct",httpcontent);
            var body = await respond.Content.ReadAsStringAsync();
            if (respond.IsSuccessStatusCode)
            {
                return body;
            }

            return "";
        }

        public async Task<CurrentCartRespond> GetCurrentCart(Guid userID)
        {
            var client = _httpClientFactory.CreateClient();
            client.BaseAddress = new Uri("https://localhost:44354");
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _userSingleton.GetToken());
            var respond = await client.GetAsync("/api/Order/GetCurrentCart/"+userID);
            var body = await respond.Content.ReadAsStringAsync();
            if (respond.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<CurrentCartRespond>(body);
            }

            return new CurrentCartRespond();
        }
        public async Task<bool> RemoveProduct(int orderDetailID)
        {
            var json = JsonConvert.SerializeObject(orderDetailID);
            var httpcontent = new StringContent(json, Encoding.UTF8, "application/json");

            var client = _httpClientFactory.CreateClient();
            client.BaseAddress = new Uri("https://localhost:44354");
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _userSingleton.GetToken());
            var respond = await client.PostAsync("/api/Order/RemoveProduct", httpcontent);
            var body = await respond.Content.ReadAsStringAsync();
            if (respond.IsSuccessStatusCode)
            {
                return true;
            }

            return false;
        }
        public async Task<bool> Clear(int orderID)
        {
            var json = JsonConvert.SerializeObject(orderID);
            var httpcontent = new StringContent(json, Encoding.UTF8, "application/json");

            var client = _httpClientFactory.CreateClient();
            client.BaseAddress = new Uri("https://localhost:44354");
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _userSingleton.GetToken());
            var respond = await client.PostAsync("/api/Order/ClearCart", httpcontent);
            var body = await respond.Content.ReadAsStringAsync();
            if (respond.IsSuccessStatusCode)
            {
                return true;
            }

            return false;
        }
        public async Task<bool> ChangeQuantity(ChangeQuantityRequest request)
        {
            var json = JsonConvert.SerializeObject(request);
            var httpcontent = new StringContent(json, Encoding.UTF8, "application/json");

            var client = _httpClientFactory.CreateClient();
            client.BaseAddress = new Uri("https://localhost:44354");
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _userSingleton.GetToken());
            var respond = await client.PostAsync("/api/Order/ChangeQuantity", httpcontent);
            var body = await respond.Content.ReadAsStringAsync();
            if (respond.IsSuccessStatusCode)
            {
                return true;
            }

            return false;
        }
        public async Task<bool> Checkout(int orderID)
        {
            var json = JsonConvert.SerializeObject(orderID);
            var httpcontent = new StringContent(json, Encoding.UTF8, "application/json");

            var client = _httpClientFactory.CreateClient();
            client.BaseAddress = new Uri("https://localhost:44354");
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _userSingleton.GetToken());
            var respond = await client.PostAsync("/api/Order/Checkout", httpcontent);
            var body = await respond.Content.ReadAsStringAsync();
            if (respond.IsSuccessStatusCode)
            {
                return true;
            }

            return false;
        }
        public async Task<CurrentCartRespond> CheckoutInfo(int id)
        {
            var client = _httpClientFactory.CreateClient();
            client.BaseAddress = new Uri("https://localhost:44354");
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _userSingleton.GetToken());
            var respond = await client.GetAsync("/api/Order/CheckoutInfo/" + id);
            var body = await respond.Content.ReadAsStringAsync();
            if (respond.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<CurrentCartRespond>(body);
            }

            return new CurrentCartRespond();
        }
    }
}
