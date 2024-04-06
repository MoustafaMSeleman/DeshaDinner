using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DeshaDinner.Api.Controllers
{

    [ApiExplorerSettings(IgnoreApi  = true)]
    public class ErrorController : ControllerBase
    {
        [Route("/error")]
        public IActionResult Error() =>
           Problem();
    }
}
