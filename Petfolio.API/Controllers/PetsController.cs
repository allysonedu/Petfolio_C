using Microsoft.AspNetCore.Mvc;
using Pefolio.communication.Requests;
using Pefolio.communication.Responses;
using Petfolio.Application.UseCases.Pets.Register;
using Petfolio.Application.UseCases.Pets.Update;

namespace Petfolio.API.Controllers;
[Route("api/[controller]")]
[ApiController]
public class PetsController : ControllerBase
{
    [HttpPost]
    [ProducesResponseType(typeof(ResponseRegisterPets), StatusCodes.Status201Created)]
    [ProducesResponseType(typeof(ResponseError), StatusCodes.Status400BadRequest)]
    public IActionResult Register([FromBody] RequestPets request)
    {
        var response = new RegisterPetsUseCase();
        response.Execute(request);

        return Created(string.Empty, response);
    }

    [HttpPut]
    [Route("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(typeof(ResponseError), StatusCodes.Status400BadRequest)]


    public IActionResult Update([FromRoute] int id, [FromBody] RequestPets request)
    {
        var useCase = new UpdatePetsUseCase();

        useCase.Execute(id, request);

        return NoContent();
    }

}
