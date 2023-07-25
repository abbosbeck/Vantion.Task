using Microsoft.AspNetCore.Http;
using Vention.Internship.CsvParser.Domain.Entities;

namespace Vention.Internship.CsvParser.Service.Services
{
    public interface IUserService
    {
        ValueTask<List<User>> CreateUserAsync(IFormFile formFile, string wwwrootPath);
    }
}
