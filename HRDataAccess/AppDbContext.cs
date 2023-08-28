using HRDataAccess.Entites;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HRDataAccess
{
    public class AppDbContext : IdentityDbContext<AppUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> dbContextOptions) : base(dbContextOptions)
        {

        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Adress> Adresses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Employee>()
                .Property(e => e.Email)
                .HasDefaultValueSql("'nabiddinov@gmail.com'");

            modelBuilder.Entity<Adress>()
                .HasData(new Adress()
                {
                    Id = 20,
                    AddresLine1 = "1,Parkent tumani",
                    AddresLine2 = "2,Boyqozon Qo'rg'on",
                    Postalcode = "777777",
                    City = "Tashkent",
                    Country = "Uzbekistan"
                });
        }
    }
}