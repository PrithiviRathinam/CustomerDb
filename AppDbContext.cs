using Microsoft.EntityFrameworkCore;
using MongoDB.EntityFrameworkCore.Extensions;

namespace MongoDBEFCoreDemo
{
    public class AppDbContext : DbContext
    {
        public DbSet<Customer> Customers { get; init; }


        public AppDbContext(DbContextOptions options)
        : base(options)
        {
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            modelBuilder.Entity<Customer>();
        }
    }

}
