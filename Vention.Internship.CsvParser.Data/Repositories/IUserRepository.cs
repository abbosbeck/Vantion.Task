using Vention.Internship.CsvParser.Domain.Entities;

namespace Vention.Internship.CsvParser.Data.Repositories
{
    public interface IUserRepository
    {
        ValueTask CreateUserAsync(User user);
        ValueTask<User> GetUserByIdAsync(Guid id);
        ValueTask UpdateUserAsync(Guid id, User user);
    }
}
