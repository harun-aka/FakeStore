using Entities.Concrete;
using Entities.DTOs;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System;
using System.Text;
using RestSharp;

namespace FakeStoreApiService
{
    public class FakeStoreApiServiceManager
    {
        public string Login(UserForLoginDto userForLoginDto)
        {
            var url = "https://fakestoreapi.com";

            var json = JsonConvert.SerializeObject(new UserForLoginDto { Username = "mor_2314", Password = "83r5^_" });

            var restClient = new RestClient(url);
            var request = new RestRequest("/auth/login", Method.Post);
            request.AddHeader("Content-Type", "application/json");


            request.AddBody(new { username = userForLoginDto.Username, password = userForLoginDto.Password });

            var response = restClient.ExecuteAsync(request);
            string rawResponse =string.Empty;

            if (response.Result.StatusCode == System.Net.HttpStatusCode.OK)
            {
                rawResponse = response.Result.Content;
            }

            var pageResponse = JsonConvert.DeserializeObject<string>(rawResponse);
            return pageResponse;
        }

        public List<Product> GetProducts()
        {
            var url = "https://fakestoreapi.com";

            var restClient = new RestClient(url);
            var request = new RestRequest("/products", Method.Get);
            request.AddHeader("Content-Type", "application/json");

            var response = restClient.ExecuteAsync(request);
            string rawResponse = string.Empty;

            if (response.Result.StatusCode == System.Net.HttpStatusCode.OK)
            {
                rawResponse = response.Result.Content;
            }

            var pageResponse = JsonConvert.DeserializeObject<List<Product>>(rawResponse);

            return pageResponse;
        }
    }
}