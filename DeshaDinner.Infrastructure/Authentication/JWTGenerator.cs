using DeshaDinner.Application.Common.Interfaces;
using DeshaDinner.Domain.User;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Xml.Linq;

namespace DeshaDinner.Infrastructure.Authentication;

public class JWTGenerator : IJWTGenerator
{
    private readonly IDateTimeProvider _dateTimeProvider;
    private readonly JwtSettings _jwtSettings;

    public JWTGenerator(IDateTimeProvider dateTimeProvider, IOptions<JwtSettings> jwtSettings)
    {
        _dateTimeProvider = dateTimeProvider;
        _jwtSettings = jwtSettings.Value;
    }
    public string GenerateToken(User User)
    {
        var signingCredentials = new SigningCredentials(
            new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwtSettings.Secret)),
            SecurityAlgorithms.HmacSha256
         );
        
      var claims = new[]
      {
         new Claim( JwtRegisteredClaimNames.Sub, User.Id.ToString() ),
         new Claim( JwtRegisteredClaimNames.GivenName, User.FirstName ),
         new Claim( JwtRegisteredClaimNames.FamilyName, User.LastName ),
         new Claim( JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString() ),
      };

        var securityToken = new JwtSecurityToken(
            issuer: _jwtSettings.Issuer,
            audience: _jwtSettings.Audience,
            expires:_dateTimeProvider.UtcNow.AddMinutes(_jwtSettings.ExpirationTimeInMinutes),
            claims: claims,
            signingCredentials: signingCredentials);

  
        return new JwtSecurityTokenHandler().WriteToken( securityToken );

    }
}
