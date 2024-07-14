using Microsoft.EntityFrameworkCore;

namespace Entity
{
    // Add DBcontext class
    public class RentCarDbContext : DbContext
    {
        // Add DBset properties
        public DbSet<CarEntity> Cars { get; set; }
        public DbSet<CarRentalEntity> CarRentals { get; set; }
        public DbSet<CustomerEntity> Persons { get; set; }

        // Add a constructor that accepts DbContextOptions
        public RentCarDbContext(DbContextOptions<RentCarDbContext> options) : base(options)
        {
        }

        // Override on model creating
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CarEntity>().HasKey(c => c.Id);
            modelBuilder.Entity<CarRentalEntity>().HasKey(c => c.RentalCardId);
            modelBuilder.Entity<CustomerEntity>().HasKey(c => c.Id);
            modelBuilder.Entity<CustomerEntity>().HasMany(c => c.CarRentals).WithOne(c => c.Person);


        }

        // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        // {
        //     optionsBuilder.UseSqlServer("Server=localhost;Database=RentCar;Trusted_Connection=True;");
        // }

        
    }
}