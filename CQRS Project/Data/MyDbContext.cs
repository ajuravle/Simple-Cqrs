using CQRS_Project.Models;
using Microsoft.EntityFrameworkCore;

namespace CQRS_Project.Data
{
    public class MyDbContext: DbContext
    {

        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBulder)
        {
            base.OnConfiguring(optionsBulder);
            optionsBulder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=CqrsDB;Trusted_Connection=True;MultipleActiveResultSets=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasKey(t => t.Id);
            modelBuilder.Entity<User>().Property(t => t.Username).HasMaxLength(20).IsRequired();
            modelBuilder.Entity<User>().Property(t => t.Password).IsRequired();

            base.OnModelCreating(modelBuilder);
        }
    }
}
