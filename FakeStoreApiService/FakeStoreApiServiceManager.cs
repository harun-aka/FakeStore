using Entities.Concrete;
using Entities.DTOs;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System;
using System.Text;
using RestSharp;
using System.IO;

namespace FakeStoreApiService
{
    public class FakeStoreApiServiceManager
    {
        public string Login(UserForLoginDto userForLoginDto)
        {
            var endpointJson = File.ReadAllText("endpoints.json");
            var endpoint = JsonConvert.DeserializeObject<Endpoint>(endpointJson);
            if (endpoint == null)
            {
                return string.Empty;
            }

            var restClient = new RestClient(endpoint.Url);
            var request = new RestRequest(endpoint.LoginEndpoint, Method.Post);
            request.AddHeader("Content-Type", "application/json");


            request.AddBody(new { username = userForLoginDto.Username, password = userForLoginDto.Password });

            var response = restClient.ExecuteAsync(request);
            string rawResponse =string.Empty;

            if (response.Result.StatusCode == System.Net.HttpStatusCode.OK)
            {
                rawResponse = response.Result.Content;
            }

            var pageResponse = JsonConvert.DeserializeObject<LoginResponse>(rawResponse);
            if(pageResponse == null)
            {
                return string.Empty;
            }
            return pageResponse.Token;
        }

        public List<Product> GetProducts()
        {
            var endpointJson = File.ReadAllText("endpoints.json");
            var endpoint = JsonConvert.DeserializeObject<Endpoint>(endpointJson);
            if (endpoint == null)
            {
                return new List<Product>();
            }

            var restClient = new RestClient(endpoint.Url);
            var request = new RestRequest(endpoint.ProductsEndpoint, Method.Get);
            request.AddHeader("Content-Type", "application/json");

            var response = restClient.ExecuteAsync(request);
            string rawResponse = string.Empty;

            if (response.Result.StatusCode == System.Net.HttpStatusCode.OK)
            {
                rawResponse = response.Result.Content;
            }

            var pageResponse = JsonConvert.DeserializeObject<List<Product>>(rawResponse);
            if(pageResponse == null)
            {
                return new List<Product>();
            }

            return pageResponse;
        }
    }
}