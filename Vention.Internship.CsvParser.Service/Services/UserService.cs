using Microsoft.AspNetCore.Http;
using Vention.Internship.CsvParser.Data.Repositories;
using Vention.Internship.CsvParser.Domain.Entities;
using Vention.Internship.CsvParser.Service.Exceptions;
using Vention.Internship.CsvParser.Service.Helpers;

namespace Vention.Internship.CsvParser.Service.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository userRepository;
        public UserService(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }
        public async ValueTask<List<User>> CreateUserAsync(IFormFile formFile, string wwwrootPath)
        {
            string fileType = formFile.ContentType;

            if (!(fileType.Equals("text/csv", StringComparison.OrdinalIgnoreCase)
                || formFile.FileName.EndsWith(".csv", StringComparison.OrdinalIgnoreCase)))
                throw new CsvParserException(400, "Invalid file type. Only CSV files are allowed.");

            string filePath = Path.Combine(wwwrootPath, "uploads", formFile.FileName);

            using (var stream = new FileStream(filePath, FileMode.Create))
            {
                await formFile.CopyToAsync(stream);
            }

            var newUsersList = CsvMapHelper.CsvToList(filePath);

            foreach (var user in newUsersList)
            {
                var userAlreadyExists = await userRepository.GetUserByIdAsync(user.UserIdentifier);

                if (userAlreadyExists != null)
                    await userRepository.UpdateUserAsync(user.UserIdentifier, user);
                else
                    await userRepository.CreateUserAsync(user);
            }

            return newUsersList;
        }
    }
}
