using Pefolio.communication.Enums;

namespace Pefolio.communication.Responses;
public class ResponseShortPets
{
    public int Id { get; set; }

    public string Name { get; set; } = string.Empty;   
    public PetsTypes PetTypes { get; set; }
}
