using System.ComponentModel.DataAnnotations;

namespace CsteConnect.Models;

public class User
{
    [Key]
    public int UserID { get; set; }
    [Required]
    [EmailAddress]
    public string Email { get; set; }
    [Required]
    public string Password { get; set; }
    
    public UserDetails UserDetails { get; set; }
    
    public ICollection<UserSocialMedia> UserSocialMedias { get; set; }
    public ICollection<AlumniDirectory> AlumniDirectories { get; set; }
    public ICollection<UserAchievement> UserAchievements { get; set; }
    public ICollection<Event> CreatedEvents { get; set; }
    public ICollection<Gallery> Galleries { get; set; }
    public ICollection<Verification> Verifications { get; set; }
    public ICollection<News> News { get; set; }
    public ICollection<Activity> Activities { get; set; }
    public ICollection<Donation> Donations { get; set; }
    public ICollection<Post> Posts { get; set; }
    public ICollection<Job> Jobs { get; set; }
}
