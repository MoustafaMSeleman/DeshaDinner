namespace DeshaDinner.Application.Services.Common;
public record AuthenticationResult
(
    Guid Id,
    string FirstName,
    string LastName,
    string Email,
    string Token
    );