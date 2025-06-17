using Microsoft.AspNetCore.Mvc;
using Pefolio.communication.Requests;
using Pefolio.communication.Responses;
using Petfolio.Application.UseCases.Pets.Register;

namespace Petfolio.API.Controllers;
[Route("api/[controller]")]
[ApiController]
public class PetsController : ControllerBase
{
    [HttpPost]
    [ProducesResponseType(typeof(ResponseRegisterPets), StatusCodes.Status201Created)]
    public IActionResult Register([FromBody] RequestRegisterPets request)
    {
        var response = new RegisterPetsUseCase().Execute(request);

        return Created(string.Empty, response);
    }
}
