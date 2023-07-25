using Microsoft.EntityFrameworkCore;
using Vention.Internship.CsvParser.Data.DbContexts;
using Vention.Internship.CsvParser.Domain.Entities;

namespace Vention.Internship.CsvParser.Data.Repositories
{
    public class UserRepositories : IUserRepository
    {
        private readonly CsvParserDbContext dbContext;
        public UserRepositories(CsvParserDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async ValueTask CreateUserAsync(User user)
        {
            await dbContext.Users.AddAsync(user);
            await dbContext.SaveChangesAsync();
        }


        public async ValueTask<User> GetUserByIdAsync(Guid id) =>
            await dbContext.Users.FindAsync(id);

        public async ValueTask UpdateUserAsync(Guid id, User user)
        {
            var oldUser = await dbContext.Users.FindAsync(id);

            if (oldUser is not null)
            {

                oldUser.Username = user.Username;
                oldUser.Age = user.Age;
                oldUser.Email = user.Email;
                oldUser.City = user.City;
                await dbContext.SaveChangesAsync();
            }
            else
            {
                throw new NullReferenceException("Not found user to update!");
            }

        }
    }
}
