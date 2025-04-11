using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CsteConnect.Domain.Models;

public class UserDetails
{
    [Key]
    public int Id { get; set; }
    public int UserId { get; set; }
    public int UserAchievementId { get; set; }
    public int UserSocialMediaId { get; set; }
    
 
    
    [Required]
    public string Phone { get; set; }
    public string Email { get; set; }  
    public string Password { get; set; }
     
    public string Designation { get; set; }
    public string Batch { get; set; }
    public string Location { get; set; }
     
}