using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CsteConnect.Domain.Models;

public class Gallery
{
    [Key]
    public int Id { get; set; }
    public int UserId { get; set; }
        
    public string Title { get; set; }
    public string Description { get; set; }
    public string FileUrl { get; set; }
    public string FileName { get; set; }
        
    // Foreign key for User
    public int CreatedById { get; set; }
      
    public int UpdatedById { get; set; }
        
    [DataType(DataType.DateTime)]
    public DateTime CreatedAt { get; set; }
        
    [DataType(DataType.DateTime)]
    public DateTime UpdatedAt { get; set; }
}