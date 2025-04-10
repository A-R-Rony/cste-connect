using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CsteConnect.Models;

public class News
{
    [Key]
    public int NewsId { get; set; }
        
    public string Title { get; set; }
    public string Content { get; set; }
    public string ImageUrl { get; set; }
    public string DonorId { get; set; }
    public string DurationId { get; set; }
        
    // Foreign key for creator User
    public int CreatedBy { get; set; }
    [ForeignKey("CreatedBy")]
    public User Creator { get; set; }
        
    public string UpdatedBy { get; set; }
        
    [DataType(DataType.DateTime)]
    public DateTime CreatedAt { get; set; }
        
    [DataType(DataType.DateTime)]
    public DateTime UpdatedAt { get; set; }
}