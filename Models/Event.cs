using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CsteConnect.Models;

public class Event
{
    [Key]
    public int EventId { get; set; }
        
    public string Title { get; set; }
    public string Description { get; set; }
    public string Location { get; set; }
        
    [DataType(DataType.DateTime)]
    public DateTime StartTime { get; set; }
        
    [DataType(DataType.DateTime)]
    public DateTime EndTime { get; set; }
        
    [DataType(DataType.DateTime)]
    public DateTime CreatedAt { get; set; }
        
    [DataType(DataType.DateTime)]
    public DateTime UpdatedAt { get; set; }
        
    // Foreign key for creator User
    public int CreatedBy { get; set; }
    [ForeignKey("CreatedBy")]
    public User Creator { get; set; }
        
    public string UpdatedBy { get; set; }
}