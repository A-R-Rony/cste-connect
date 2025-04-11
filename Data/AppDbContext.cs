using CsteConnect.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace CsteConnect.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }
    public DbSet<User> Users { get; set; }
    public DbSet<UserDetails> UserDetails { get; set; }
    public DbSet<UserSocialMedia> UserSocialMedias { get; set; }
    public DbSet<AlumniDirectory> AlumniDirectories { get; set; }
    public DbSet<UserAchievement> UserAchievements { get; set; }
    public DbSet<Event> Events { get; set; }
    public DbSet<Gallery> Galleries { get; set; }
    public DbSet<Verification> Verifications { get; set; }
    public DbSet<News> News { get; set; }
    public DbSet<Activity> Activities { get; set; }
    public DbSet<Donation> Donations { get; set; }
    
    public DbSet<Job> Jobs { get; set; }

}