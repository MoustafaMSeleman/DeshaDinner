using DeshaDinner.Application.Services.Common;
using ErrorOr;
using MediatR;

namespace DeshaDinner.Application.Services.Queries;

public record LoginQuery
(
    string Email,
    string Password
    ): IRequest<ErrorOr<AuthenticationResult>>;
