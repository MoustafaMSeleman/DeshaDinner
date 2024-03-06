namespace DeshaDinner.Application.Services;

public interface IAtuhenticationService
{
    AuthentucationResult Register (string firstName, string lastName, string email, string password);
    AuthentucationResult Login (string email, string password);
}