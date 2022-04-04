using Entities.Concrete;
using Entities.DTOs;
using System.Collections.Generic;

namespace Core.Services.Abstract
{
    public interface IDbService
    {
        string Login(UserForLoginDto userForLoginDto);
        List<Product> GetProducts();
    }
}
