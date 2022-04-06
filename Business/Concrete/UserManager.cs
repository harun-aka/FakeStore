using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.DTOs;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public IDataResult<string> Login(UserForLoginDto userForLoginDto)
        {
            string token = _userDal.Login(userForLoginDto);
            if(string.IsNullOrEmpty(token))
            {
                return new ErrorDataResult<string>(token, Messages.AccessTokenCreated);
            }           
            return new SuccessDataResult<string>(token, Messages.AccessTokenCreated);
        }
    }
}
