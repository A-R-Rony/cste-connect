using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CsteConnect.Domain.Models;

public class AlumniDirectory
{
    [Key]
    public int Id { get; set; }
    public int UserId { get; set; }
    public int SocialMediaId { get; set; }
    public int UserDetailId { get; set; }
    public int UserAchievementId { get; set; }
    public int Status { get; set; }
    
    
    public int CreatedById { get; set; }
    public int UpdatedById { get; set; }
        
    [DataType(DataType.DateTime)]
    public DateTime CreatedAt { get; set; }
        
    [DataType(DataType.DateTime)]
    public DateTime UpdatedAt { get; set; }
        
    
}