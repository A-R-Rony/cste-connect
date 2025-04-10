using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CsteConnect.Models;

public class Activity
{
    [Key]
    public int ActivityId { get; set; }
        
    public string ActivityType { get; set; }
    public string Discussion { get; set; }
        
    // Foreign key for User
    public int UserId { get; set; }
    [ForeignKey("UserId")]
    public User User { get; set; }
        
    public string CreatedBy { get; set; }
    public string UpdatedBy { get; set; }
        
    [DataType(DataType.DateTime)]
    public DateTime CreatedAt { get; set; }
        
    [DataType(DataType.DateTime)]
    public DateTime UpdatedAt { get; set; }
        
    [DataType(DataType.DateTime)]
    public DateTime VerifiedAt { get; set; }
}