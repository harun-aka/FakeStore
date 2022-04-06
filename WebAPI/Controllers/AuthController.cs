using Business.Abstract;
using Entities.DTOs;
using Microsoft.AspNetCore.Mvc;
namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : Controller
    {
        private IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost("login")]
        public ActionResult Login(UserForLoginDto userForLoginDto)
        {
            var resultLogin = _authService.Login(userForLoginDto);
            if (!resultLogin.Success)
            {
                return BadRequest(resultLogin.Message);
            }

            var result = _authService.CreateAccessToken(resultLogin.Data);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result.Message);
        }
    }
}
