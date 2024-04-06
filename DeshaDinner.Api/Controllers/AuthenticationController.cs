using DeshaDinner.Application.Services.Commands;
using DeshaDinner.Application.Services.Common;
using DeshaDinner.Contracts.Authentication;

using DeshaDinner.Domain.Common.Errors;
using ErrorOr;
using MapsterMapper;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace DeshaDinner.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ApiController
    {
        private readonly IMapper _mapper;
        private readonly Mediator _mediator;

        public AuthenticationController(IMapper mapper, Mediator mediator) 
        {
            _mapper = mapper;
            _mediator = mediator;
        }
        [HttpPost("register")]
        public async Task<IActionResult> Register(RegisterRequest request)
        {
            var command = _mapper.Map<RegisterCommand>(request);

            ErrorOr<AuthenticationResult> authResult = await  _mediator.Send(command);

            return authResult.Match(
                authResult=> Ok(_mapper.Map<AuthenticationResult>(authResult)),
                errors => Problem(errors)
                );
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(LoginRequest request)
        {
            return Ok(request);
        }
    }
}
