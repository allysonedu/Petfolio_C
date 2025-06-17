using Microsoft.AspNetCore.Mvc;
using Pefolio.communication.Requests;
using Pefolio.communication.Responses;

namespace Petfolio.API.Controllers;
[Route("api/[controller]")]
[ApiController]
public class PetsController : ControllerBase
{
    [HttpPost]
    [ProducesResponseType(typeof(ResponseRegisterPets), StatusCodes.Status201Created)]
    public IActionResult Register([FromBody] RequestRegisterPets request)
    {
        return Created();
    }
}
