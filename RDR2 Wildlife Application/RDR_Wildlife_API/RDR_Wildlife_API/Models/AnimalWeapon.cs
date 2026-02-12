namespace RDR_Wildlife_API.Models;

public class AnimalWeapon
{
    public int AnimalId { get; set; }
    public Animal Animal { get; set; } = null!;
    
    public int WeaponId { get; set; }
    public Weapon Weapon { get; set; } = null!;
}