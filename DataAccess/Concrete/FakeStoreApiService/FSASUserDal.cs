using Core.Services.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.DTOs;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;

namespace DataAccess.Concrete.EntityFramework
{
    public class FSASUserDal : IUserDal
    {
        IDbService _dbService;

        public FSASUserDal(IDbService dbService)
        {
            _dbService = dbService;
        }

        public string Login(UserForLoginDto userForLoginDto)
        {
            return _dbService.Login(userForLoginDto);
        }
    }
}
