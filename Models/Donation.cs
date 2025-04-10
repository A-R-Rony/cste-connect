using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CsteConnect.Models;

public class Donation
{
    [Key]
    public int DonationId { get; set; }
        
    public decimal Amount { get; set; }
    public string Purpose { get; set; }
    public string DonationType { get; set; }
        
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
    public DateTime DonatedAt { get; set; }
}