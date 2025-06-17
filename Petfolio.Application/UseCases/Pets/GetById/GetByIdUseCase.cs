using Pefolio.communication.Responses;

namespace Petfolio.Application.UseCases.Pets.GetById;
public class GetByIdUseCase
{
    public ResponsePets Execute(int id)
    {
        return new ResponsePets
        {
            Id = id,
            Name = "opaaaa",
            Type = Pefolio.communication.Enums.PetsTypes.Dog,
            Birthday = new DateTime(year: 2000, month: 01, day: 1)
        };

    }
}
