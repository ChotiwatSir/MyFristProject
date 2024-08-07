
using System.Reflection;
using Microsoft.EntityFrameworkCore;
using MyFristProject.Entities;

namespace MyFristProject.Contexts
{
    public class MyContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<CustomerDetail> CustomerDetails { get; set; }
        public DbSet<CousinCustomer> CousinCustomers { get; set; }

        public MyContext()
        {

        }
        public MyContext(DbContextOptions<MyContext> options) : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server = localhost; user id = sa; password = Sirinam44; database= MyFristDB;trustservercertificate = true;");
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {

            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            // builder.ApplyConfiguration(new CustomerConfiguration());
            // builder.ApplyConfiguration(new CustomerDetailConfiguration());


        }
    }
}
