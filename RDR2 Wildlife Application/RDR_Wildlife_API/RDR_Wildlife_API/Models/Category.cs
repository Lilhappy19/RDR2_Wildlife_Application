using System.ComponentModel.DataAnnotations;

namespace RDR_Wildlife_API.Models;

public class Category
{
    public enum Size
    {
        Small,
        Moderate,
        Medium,
        Large,
        Massive,
        Legendary
    }
    
    public int Id { get; set; }
    [Required][EnumDataType(typeof(Size))]public Size CategorySize { get; set; }

    public virtual List<Animal> Animals { get; set; } = new();
}