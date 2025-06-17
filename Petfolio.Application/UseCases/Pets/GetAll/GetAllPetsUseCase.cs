using Pefolio.communication.Responses;

namespace Petfolio.Application.UseCases.Pets.GetAll;
public class GetAllPetsUseCase
{
    public ResponseAllPets Exexute()
    {
        return new ResponseAllPets
        {
            Pets = new List<ResponseShortPets>
          {
              new ResponseShortPets {
              Id = 1,
              Name = "slaaaa",
              PetTypes = Pefolio.communication.Enums.PetsTypes.Dog
              }
          }
        };
    }
}
