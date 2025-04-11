using CsteConnect.Application.Interfaces;
using CsteConnect.Domain.Models;

namespace CsteConnect.Data.Repositories;

public class UserRepository(AppDbContext context) : IUserRepository
{
    public User Add(User user)
    {
        context.Users.Add(user);
        context.SaveChanges();
        return user;
    }
}