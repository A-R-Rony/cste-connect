using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CsteConnect.Domain.Models;

public class Activity
{
    [Key]
    public int Id { get; set; }
        
    public string ActivityType { get; set; }
    public string Discussion { get; set; }
      
    public int UserId { get; set; }
    public int CreatedById { get; set; }
    public int UpdatedById { get; set; }
        
    [DataType(DataType.DateTime)]
    public DateTime CreatedAt { get; set; }
        
    [DataType(DataType.DateTime)]
    public DateTime UpdatedAt { get; set; }
        
    [DataType(DataType.DateTime)]
    public DateTime VerifiedAt { get; set; }
}