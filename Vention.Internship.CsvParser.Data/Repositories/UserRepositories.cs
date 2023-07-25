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

        public async ValueTask<User> CreateUserAsync(User user)
        {
            await dbContext.Users.AddAsync(user);

            return user;
        }


        public async ValueTask<User> GetUserByIdAsync(Guid id) =>
            await dbContext.Users.FindAsync(id);

        public async ValueTask<User> UpdateUserAsync(Guid id, User user)
        {
            var oldUser = await dbContext.Users.FindAsync(id);

            if (oldUser is not null)
            {
                user.UserIdentifier = id;
                dbContext.Users.Update(user);
                await dbContext.SaveChangesAsync();

                return user;
            }

            throw new NullReferenceException("Not found user to update!");
        }
    }
}
