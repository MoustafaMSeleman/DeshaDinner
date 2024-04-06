using DeshaDinner.Domain.User;

namespace DeshaDinner.Application.Common.Interfaces;

public interface IJWTGenerator
{
    string GenerateToken(User User);
}
