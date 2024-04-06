using DeshaDinner.Domain.User;

namespace DeshaDinner.Application.Common.Persistence;

public interface IUserRepository
{
    User? GetUserByEmail(string email);
    void Add(User user);
}
