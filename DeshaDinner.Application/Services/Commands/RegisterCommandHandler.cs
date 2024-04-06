using DeshaDinner.Application.Common.Interfaces;
using DeshaDinner.Application.Common.Persistence;
using DeshaDinner.Application.Services.Common;
using DeshaDinner.Domain.Common.Errors;
using DeshaDinner.Domain.User;
using ErrorOr;
using MediatR;

namespace DeshaDinner.Application.Services.Commands;
public class RegisterCommandHandler : IRequestHandler<RegisterCommand, ErrorOr<AuthenticationResult>>
{
    
    private readonly IJWTGenerator _jwtGenerator;
    private readonly IUserRepository _userRepository;
    public RegisterCommandHandler(IJWTGenerator jwtGenerator, IUserRepository userRepository)
    {
        _jwtGenerator = jwtGenerator;
        _userRepository = userRepository;
    }
    public async Task<ErrorOr<AuthenticationResult>> Handle(RegisterCommand command, CancellationToken cancellationToken)
    {
        await Task.CompletedTask;
        //check if the user exist
        if (_userRepository.GetUserByEmail(command.Email) is not null)
            return Errors.User.DuplicateEmail;
        //add user 
        var user = new User 
        { 
            FirstName = command.FirstName,
            LastName = command.LastName,
            Email = command.Email,
            Password = command.Password,
        };
        //generate jwt
        var token = _jwtGenerator.GenerateToken(user);
        return new AuthenticationResult(
            user.Id,
            user.FirstName,
            user.LastName,
            user.Email,
            token
            );
    }
}
