using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doit.Infrastructure.Extension_Methods
{
    public static class TokenGeneration
    {

        private static string tokenKey = "thisisaverysecurekeyastatickeyarandomkey";
        public static string GenerateToken(this long? userId)
        {
            var symmetricSecurityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(tokenKey));
            var signingCredentials = new SigningCredentials(symmetricSecurityKey, SecurityAlgorithms.HmacSha256Signature);

            var header = new JwtHeader(signingCredentials);

            var payload = new JwtPayload(Convert.ToString(userId), null, null, null, DateTime.Today.AddDays(1));

            var securityToken = new JwtSecurityToken(header, payload);

            return new JwtSecurityTokenHandler().WriteToken(securityToken);
        }
    }
}
