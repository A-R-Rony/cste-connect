using System.ComponentModel.DataAnnotations;

namespace CsteConnect.Domain.Models;

public class User
{
    [Key]
    public int Id { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string ProfilePicture { get; set; }

    public User()
    {
        
    }
    /*
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
    */
}
