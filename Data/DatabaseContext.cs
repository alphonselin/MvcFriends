using Microsoft.EntityFrameworkCore;
using MvcFriends.Models;

namespace MvcFriends.Data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) {}

        public DbSet<Friend> Friends { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Friend>().HasData(
                new Friend { Id=1, Name="Kevin", Email="kevin@gmail.com", Mobile="0955-259885"},
                new Friend { Id=2, Name="Daivd", Email="david@gmail.com", Mobile="0922-354286"},
                new Friend { Id=3, Name="Mary", Email="mary@gmail.com", Mobile="0935-823714"}
            );
        }
    }
}