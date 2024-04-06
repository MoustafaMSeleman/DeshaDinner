using DeshaDinner.Application.Services.Common;
using ErrorOr;
using MediatR;

namespace DeshaDinner.Application.Services.Commands;

public record RegisterCommand
(
    string FirstName,
    string LastName,
    string Email,
    string Password
    ) : IRequest<ErrorOr<AuthenticationResult>>;
