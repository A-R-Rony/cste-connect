using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CsteConnect.Domain.Models;

public class Verification
{
    [Key]
    public int Id { get; set; }
    public int UserId { get; set; }
        
    public string VerificationRequestType { get; set; }
    public string FileName { get; set; }
    
        
    public int VerifiedById { get; set; }
        
    [DataType(DataType.DateTime)]
    public DateTime VerifiedAt { get; set; }
        
    [DataType(DataType.DateTime)]
    public DateTime CreatedAt { get; set; }
        
    [DataType(DataType.DateTime)]
    public DateTime UpdatedAt { get; set; }
        
    public int CreatedById { get; set; }
    public int UpdatedById { get; set; }
}