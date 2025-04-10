using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CsteConnect.Models;

public class UserDetails
{
    [Key]
    public int UserDetailsId { get; set; }
    
    public int UserId { get; set; }
    [ForeignKey("UserId")]
    public User User { get; set; }
    
    [Required]
    public string Phone { get; set; }
    public string Company { get; set; }
    public string Designation { get; set; }
        
    // Additional fields from ERD
    public string Batch { get; set; }
    public string Location { get; set; }

}