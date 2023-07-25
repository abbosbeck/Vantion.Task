using System.Globalization;
using CsvHelper;
using CsvHelper.Configuration;
using Vention.Internship.CsvParser.Domain.Entities;

namespace Vention.Internship.CsvParser.Service.Helpers
{
    public static class CsvMapHelper
    {
        public static List<User> CsvToList(string path)
        {
            using (var streamReader = new StreamReader(path))
            {
                using (var csvReader = new CsvReader(streamReader, CultureInfo.InvariantCulture))
                {
                    csvReader.Context.RegisterClassMap<UserClassMap>();

                    return csvReader.GetRecords<User>().ToList();
                }
            }
        }
    }

    public class UserClassMap : ClassMap<User>
    {
        public UserClassMap()
        {
            Map(m => m.UserIdentifier).Name("useridentifier");
            Map(m => m.Username).Name("username");
            Map(m => m.Age).Name("age");
            Map(m => m.City).Name("city");
            Map(m => m.PhoneNumber).Name("phonenumber");
            Map(m => m.Email).Name("email");
        }
    }
}
