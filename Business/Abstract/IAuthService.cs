using Core.Utilities.Results;
using Core.Utilities.Security.JWT;
using Entities.DTOs;

namespace Business.Abstract
{
    public interface IAuthService
    {
        IDataResult<string> Login(UserForLoginDto userForLoginDto);
        IDataResult<AccessToken> CreateAccessToken(string token);
    }
}
