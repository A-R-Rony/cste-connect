using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CsteConnect.Models;

public class UserAchievement
{
    [Key]
    public int UserAchievementId { get; set; }
        
    // Foreign key for User
    public int UserId { get; set; }
    [ForeignKey("UserId")]
    public User User { get; set; }
        
    public string AchievedBy { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
        
    [DataType(DataType.DateTime)]
    public DateTime CreatedAt { get; set; }
        
    [DataType(DataType.DateTime)]
    public DateTime UpdatedAt { get; set; }
        
    public string CreatedBy { get; set; }
    public string UpdatedBy { get; set; }
}