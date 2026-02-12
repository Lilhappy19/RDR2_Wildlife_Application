using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RDR_Wildlife_API.Models;

public class Animal
{
    public int Id { get; set; }
    [Required] public string Name { get; set; } = null!;
    
    public int CategoryId { get; set; }
    [ForeignKey("CategoryId")]
    public virtual Category Category { get; set; } = null!;
    
    public virtual List<AnimalWeapon> Weapons { get; set; } = new();
    
    public virtual List<AnimalLocation> Locations { get; set; } = new();
}