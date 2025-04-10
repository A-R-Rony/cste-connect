using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CsteConnect.Models;

public class UserSocialMedia
{
    [Key]
    public int UserSocialMediaId { get; set; }
    // Foreign key for User
    public int UserId { get; set; }
    [ForeignKey("UserId")]
    public User User { get; set; }
        
    public string GithubId { get; set; }
    public string LinkedinId { get; set; }
    public string FbId { get; set; }
}