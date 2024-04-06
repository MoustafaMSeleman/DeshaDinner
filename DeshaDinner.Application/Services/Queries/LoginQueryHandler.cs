using DeshaDinner.Application.Services.Commands;
using DeshaDinner.Application.Services.Common;
using ErrorOr;
using MediatR;

namespace DeshaDinner.Application.Services.Queries;

public class LoginQueryHandler : IRequestHandler<LoginQuery, ErrorOr<AuthenticationResult>>
{
    

    public LoginQueryHandler()
    {
       
    }

    public Task<ErrorOr<AuthenticationResult>> Handle(LoginQuery query, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
