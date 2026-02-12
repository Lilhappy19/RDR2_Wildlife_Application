using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace RDR_Wildlife_API.Models;

public class User
{
    public enum UserRole
    {
        User,
        Admin
    }
    
    public int Id { get; set; }
    [Required] [MaxLength(200)]public string FirstName { get; set; }=null!;
    [Required] [MaxLength(200)]public string LastName { get; set; }=null!;
    [Required] [MaxLength(50)]public string Username { get; set; }=null!;
    [Required] [EmailAddress] [MaxLength(100)]public string Email { get; set; }=null!;
    [Required] [JsonIgnore]public string PasswordHash { get; set; } = null!;
    
    [EnumDataType(typeof(UserRole))]public UserRole Role { get; set; }= UserRole.User;
}