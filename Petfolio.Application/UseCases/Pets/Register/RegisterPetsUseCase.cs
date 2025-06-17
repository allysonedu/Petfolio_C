using Pefolio.communication.Requests;
using Pefolio.communication.Responses;

namespace Petfolio.Application.UseCases.Pets.Register;
public class RegisterPetsUseCase
{
    public  ResponseRegisterPets Execute(RequestPets request)
    {
        return new ResponseRegisterPets
        {
            Id = 7,
            Name = request.Name,
        };

    }
}
