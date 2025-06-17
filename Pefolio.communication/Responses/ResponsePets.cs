using Pefolio.communication.Enums;

namespace Pefolio.communication.Responses;
public class ResponsePets
{  
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;

    public DateTime Birthday { get; set; }

    public PetsTypes Type { get; set; }
}
