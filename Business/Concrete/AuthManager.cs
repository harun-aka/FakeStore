using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class AuthManager : IAuthService
    {
        IUserService _userService;
        public AuthManager(IUserService userService)
        {
            _userService = userService;
        }

        public IDataResult<string> Login(UserForLoginDto userForLoginDto)
        {
            
            return new SuccessDataResult<string>(_userService.Login(userForLoginDto).Data, Messages.SuccessfulLogin);
        }

    }
}
