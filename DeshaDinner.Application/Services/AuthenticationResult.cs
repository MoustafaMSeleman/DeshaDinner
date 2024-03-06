using System.Security.Cryptography.X509Certificates;

namespace DeshaDinner.Application.Services;
public record AuthentucationResult(
    Guid Id,
    string FirstName,
    string LastName,
    string Email,
    string Token
);