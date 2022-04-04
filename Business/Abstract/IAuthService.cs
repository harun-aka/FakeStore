using Core.Utilities.Results;
using Entities.DTOs;

namespace Business.Abstract
{
    public interface IAuthService
    {
        IDataResult<string> Login(UserForLoginDto userForLoginDto);
    }
}
