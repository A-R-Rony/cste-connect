using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CsteConnect.Models;

public class Post
{
    [Key]
    public int PostId { get; set; }
        
    // Foreign key for User
    public int UserId { get; set; }
    [ForeignKey("UserId")]
    public User User { get; set; }
        
    public string Content { get; set; }
}