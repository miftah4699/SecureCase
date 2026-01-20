using SecureCase.Application.Interface;
using SecureCase.Domain.Entities;

namespace SecureCase.Infrastructure.Repositories;

public class UserRepository : IUserRepository
{
    private static readonly List<User> _users = new();

    public Task<User?> GetByEmailAsync(string email)
    {
        return Task.FromResult(_users.FirstOrDefault(x => x.Email == email));
    }

    public Task AddAsync(User user)
    {
        _users.Add(user);
        return Task.CompletedTask;
    }
}
