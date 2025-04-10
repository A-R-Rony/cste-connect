using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CsteConnect.Models;

public class Gallery
{
    [Key]
    public int GalleryId { get; set; }
        
    public string Title { get; set; }
    public string Description { get; set; }
    public string FileUrl { get; set; }
    public string FileName { get; set; }
        
    // Foreign key for User
    public int CreatedBy { get; set; }
    [ForeignKey("CreatedBy")]
    public User Creator { get; set; }
        
    public string UpdatedBy { get; set; }
        
    [DataType(DataType.DateTime)]
    public DateTime CreatedAt { get; set; }
        
    [DataType(DataType.DateTime)]
    public DateTime UpdatedAt { get; set; }
}