using Pefolio.communication.Enums;

namespace Pefolio.communication.Requests;
public class RequestPets
{
    public string Name {  get; set; } = string.Empty;

    public DateTime Birthday { get; set; }

    public PetsTypes Type { get; set; }

}
