using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.DTOs;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;

namespace DataAccess.Concrete.EntityFramework
{
    public class FASSUserDal : IUserDal
    {
        public string Login(UserForLoginDto userForLoginDto)
        {
            //using (var client = new HttpClient())
            //{

            //    client.BaseAddress = new Uri("https://fakestoreapi.com/auth/login");
            //    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            //    var response = client.PostAsJsonAsync("api/person", userForLoginDto).Result;
            //    if (response.IsSuccessStatusCode)
            //    {
            //        var products = response.Content.ReadAsStringAsync().Result;
            //        return "asd";
            //    }
                return "fail";
            //}
        }
    }
}
