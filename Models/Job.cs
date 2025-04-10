using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CsteConnect.Models;

public class Job
{
    [Key]
    public int JobId { get; set; }
        
    public string Title { get; set; }
    public string Description { get; set; }
    public string CompanyName { get; set; }
    public string Location { get; set; }
    public string Salary { get; set; }
    public string Responsibilities { get; set; }
    public string Requirements { get; set; }
    public string Benefits { get; set; }
    public int NoOfVacancy { get; set; }
    public string Position { get; set; }
        
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
        
    public string UserAchievementId { get; set; }
    public string UserDetailId { get; set; }
}