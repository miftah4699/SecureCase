using SecureCase.Domain.Entities;

namespace SecureCase.Application.Interface;

public interface IUserRepository
{
    Task<User?> GetByEmailAsync(string email);
    Task AddAsync(User user);
}
