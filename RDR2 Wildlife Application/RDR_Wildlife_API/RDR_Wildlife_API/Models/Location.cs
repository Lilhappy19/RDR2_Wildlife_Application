using System.ComponentModel.DataAnnotations;

namespace RDR_Wildlife_API.Models;

public class Location
{
    public int Id { get; set; }
    [Required] public string Name { get; set; } = null!;
    public string? ImgPath { get; set; }

    public virtual List<AnimalLocation> Animals { get; set; }= new();
}