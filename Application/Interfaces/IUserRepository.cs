using CsteConnect.Domain.Models;

namespace CsteConnect.Application.Interfaces;

public interface IUserRepository
{
    User Add(User user);
}