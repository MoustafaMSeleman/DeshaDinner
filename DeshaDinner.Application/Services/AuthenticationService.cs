namespace DeshaDinner.Application.Services;

public class AuthenticationService : IAtuhenticationService
{
    public AuthentucationResult Login(string email, string password)
    {

        return new AuthentucationResult(
            Guid.NewGuid(),
            "firstName",
            "lastName",
            email,
            "token"
        );
    }

    public AuthentucationResult Register(string firstName, string lastName, string email, string password)
    {
        return new AuthentucationResult(
            Guid.NewGuid(),
            firstName,
            lastName,
            email,
            "token"
        );
    }
}