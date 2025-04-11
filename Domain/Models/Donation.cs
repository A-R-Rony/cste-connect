using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CsteConnect.Domain.Models;

public class Donation
{
    [Key]
    public int Id { get; set; }
        
    public decimal Amount { get; set; }
    public string Purpose { get; set; }
    public string DonationType { get; set; }
        
    
   
    public int UserId { get; set; }
    public int CreatedById { get; set; }
    public int UpdatedById { get; set; }
    public int DonatedById { get; set; }
        
    [DataType(DataType.DateTime)]
    public DateTime CreatedAt { get; set; }
        
    [DataType(DataType.DateTime)]
    public DateTime UpdatedAt { get; set; }
        
    [DataType(DataType.DateTime)]
    public DateTime DonatedAt { get; set; }
}