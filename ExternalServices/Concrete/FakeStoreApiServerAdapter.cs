using Core.Services.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using FakeStoreApiService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExternalService.Concrete
{
    public class FakeStoreApiServerAdapter : IDbService
    {
        FakeStoreApiServiceManager _fakeStoreApiService;

        public FakeStoreApiServerAdapter()
        {
            _fakeStoreApiService = new FakeStoreApiServiceManager();
        }

        public List<Product> GetProducts()
        {
            return _fakeStoreApiService.GetProducts();
        }

        public string Login(UserForLoginDto userForLoginDto)
        {
            return _fakeStoreApiService.Login(userForLoginDto);           
        }

    }
}
