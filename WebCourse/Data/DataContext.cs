using Microsoft.EntityFrameworkCore;
using WebCourse.Entities;

namespace WebCourse.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<AppUser> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AppUser>().HasData(
                new AppUser[]
                {
                    new AppUser { Id=1, UserName="Bob"},
                    new AppUser { Id=2, UserName="Tom"},
                    new AppUser { Id=3, UserName="Jane"},
                });
        }
        }
}
