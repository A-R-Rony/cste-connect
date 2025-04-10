using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CsteConnect.Models;

public class AlumniDirectory
{
    [Key]
    public int AlumniDirectoryId { get; set; }
        
    // Foreign key for User
    public int UserId { get; set; }
    [ForeignKey("UserId")]
    public User User { get; set; }
        
    public string UserSocialMediaId { get; set; }
    public string UserAchievementId { get; set; }
    public string UserDetailId { get; set; }
}