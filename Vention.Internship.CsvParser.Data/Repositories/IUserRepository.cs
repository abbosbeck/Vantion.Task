﻿using Vention.Internship.CsvParser.Domain.Entities;

namespace Vention.Internship.CsvParser.Data.Repositories
{
    public interface IUserRepository
    {
        ValueTask<User> CreateUserAsync(User user);
        ValueTask<User> GetUserById(Guid id);
        ValueTask<User> UpdateUserAsync(Guid id, User user);
    }
}
