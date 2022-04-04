using Business.Abstract;
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
            return new SuccessDataResult<string>(_userDal.Login(userForLoginDto));
        }
    }
}
