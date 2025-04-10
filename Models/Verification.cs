using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CsteConnect.Models;

public class Verification
{
    [Key]
    public int VerificationId { get; set; }
        
    public string VerificationType { get; set; }
    public string FileName { get; set; }
    public string FileUrl { get; set; }
        
    // Foreign key for User
    public int UserId { get; set; }
    [ForeignKey("UserId")]
    public User User { get; set; }
        
    public string VerifiedBy { get; set; }
        
    [DataType(DataType.DateTime)]
    public DateTime VerifiedAt { get; set; }
        
    [DataType(DataType.DateTime)]
    public DateTime CreatedAt { get; set; }
        
    [DataType(DataType.DateTime)]
    public DateTime UpdatedAt { get; set; }
        
    public string CreatedBy { get; set; }
    public string UpdatedBy { get; set; }
}