using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CsteConnect.Domain.Models;

public class UserSocialMedia
{
    [Key]
    public int Id { get; set; }
    public int UserId { get; set; }
    public int UserDetailId { get; set; }
    
        
    public string GithubId { get; set; }
    public string LinkedinId { get; set; }
    public string FbId { get; set; }
}