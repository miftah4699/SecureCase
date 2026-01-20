namespace SecureCase.Domain.Entities;

public class User
{
    public Guid Id { get; private set; }
    public string Email { get; private set; }

    private User() { } // for ORM

    public User(string email)
    {
        Id = Guid.NewGuid();
        Email = email;
    }
}
