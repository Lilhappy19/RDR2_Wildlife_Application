namespace RDR_Wildlife_API.Models;

public class AnimalLocation
{
    public int AnimalId { get; set; }
    public Animal Animal { get; set; } = null!;
    
    public int LocationId { get; set; }
    public Location Location { get; set; } = null!;
}