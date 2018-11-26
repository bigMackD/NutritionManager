using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Principal;
using System.Threading.Tasks;

namespace NutritionManager.Api.Authorization
{
    public class JwtFactory : IJwtFactory
    {
        private readonly JwtIssuerOptions _issuerOptions;
        public JwtFactory(JwtIssuerOptions issuerOptions)
        {
            _issuerOptions = issuerOptions;
        }

        public ClaimsIdentity GenerateClaimsIdentity(string userName, string id)
        {
            return new ClaimsIdentity(new GenericIdentity(userName, "Token"), new[]
            {
                new Claim(Data.Helpers.Constants.Strings.JwtClaimsIdentifiers.Id, id),
                new Claim(Data.Helpers.Constants.Strings.JwtClaimsIdentifiers.Rol, Data.Helpers.Constants.Strings.JwtClaims.ApiAccess)
            });
        }

        public async Task<string> GenerateEncodedToken(string userName, ClaimsIdentity identity)
        {
            var claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.Sub,userName),
                new Claim(JwtRegisteredClaimNames.Jti, await _issuerOptions.JtiGenerator()),
                new Claim(JwtRegisteredClaimNames.Iat, ToUnixEpochDate(_issuerOptions.IssuedAt).ToString(), ClaimValueTypes.Integer64),
                  identity.FindFirst(Data.Helpers.Constants.Strings.JwtClaimsIdentifiers.Rol),
                  identity.FindFirst(Data.Helpers.Constants.Strings.JwtClaimsIdentifiers.Id)
            };
            var jwt = new JwtSecurityToken(
                issuer: _issuerOptions.Issuer,
                audience: _issuerOptions.Audience,
                claims: claims,
                notBefore: _issuerOptions.NotBefore,
                expires: _issuerOptions.Expiration,
                signingCredentials: _issuerOptions.SigningCredentials);

            var encodedJwt = new JwtSecurityTokenHandler().WriteToken(jwt);
            return encodedJwt;
        }

        private static long ToUnixEpochDate(DateTime issuedAt)
            => (long)Math.Round((issuedAt.ToUniversalTime() -
                            new DateTimeOffset(1970, 1, 1, 0, 0, 0, TimeSpan.Zero))
                .TotalSeconds);

       private static void ThrowIfInvalidOptions(JwtIssuerOptions options)
        {
            if (options == null) throw new ArgumentNullException(nameof(options));

            if(options.ValidFor <= TimeSpan.Zero)
            {
                throw new ArgumentException("Must be a non - zero TimeSpan!", nameof(JwtIssuerOptions));
            }

            if (options.SigningCredentials == null) throw new ArgumentNullException(nameof(JwtIssuerOptions.SigningCredentials));

            if (options.JtiGenerator == null) throw new ArgumentNullException(nameof(JwtIssuerOptions.JtiGenerator));
        }
    }
}
