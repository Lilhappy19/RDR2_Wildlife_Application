using System.ComponentModel.DataAnnotations;

namespace RDR_Wildlife_API.Models;

public class Weapon
{
    public enum AmmoType
    {
        Bullets,
        Arrows,
        ShotgunShells
    }
    
    public int Id { get; set; }
    [Required] public string Name { get; set; } = null!;
    [Required][EnumDataType(typeof(AmmoType))]public AmmoType Type { get; set; }
    [Required] public string SubType { get; set; } = null!;

    public virtual List<AnimalWeapon> Animals { get; set; } = new();
}