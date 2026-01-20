using SecureCase.Application.Interface;
using SecureCase.Domain.Entities;

namespace SecureCase.Application.UseCases;

public class RegisterUser
{
    private readonly IUserRepository _repository;

    public RegisterUser(IUserRepository repository)
    {
        _repository = repository;
    }

    public async Task ExecuteAsync(string email)
    {
        var existing = await _repository.GetByEmailAsync(email);
        if (existing != null)
            throw new Exception("User already exists");

        var user = new User(email);
        await _repository.AddAsync(user);
    }
}
