using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CsteConnect.Domain.Models;

public class Job
{
    [Key]
    public int Id { get; set; }
    public int UserId { get; set; }
    public int UserDetailId { get; set; }
    public int UserAchievementId { get; set; }
        
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
        
    
        
    public int CreatedById { get; set; }
    public int UpdatedById { get; set; }
        
    [DataType(DataType.DateTime)]
    public DateTime CreatedAt { get; set; }
        
    [DataType(DataType.DateTime)]
    public DateTime UpdatedAt { get; set; }
     
}