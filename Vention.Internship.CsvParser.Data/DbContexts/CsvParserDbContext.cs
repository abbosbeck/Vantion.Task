using Microsoft.EntityFrameworkCore;
using Vention.Internship.CsvParser.Domain.Entities;

namespace Vention.Internship.CsvParser.Data.DbContexts
{
    public class CsvParserDbContext : DbContext
    {
        public CsvParserDbContext(DbContextOptions<CsvParserDbContext> options) : base(options)
            { }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasKey(u => u.UserIdentifier);


            base.OnModelCreating(modelBuilder);
        }
    }
}
