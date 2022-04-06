using Microsoft.Extensions.Configuration;
using System;

namespace Core.Utilities.Security.JWT
{
    public class CustomTokenHelper : ITokenHelper
    {
        public IConfiguration Configuration { get; }
        private TokenOptions _tokenOptions;
        private DateTime _accessTokenExpiration;
        public CustomTokenHelper(IConfiguration configuration)
        {
            Configuration = configuration;
            _tokenOptions = Configuration.GetSection("TokenOptions").Get<TokenOptions>();

        }
        public AccessToken CreateToken(string token)
        {
            _accessTokenExpiration = DateTime.Now.AddMinutes(_tokenOptions.AccessTokenExpiration);

            return new AccessToken
            {
                Token = token,
                Expiration = _accessTokenExpiration
            };

        }
    }
}
