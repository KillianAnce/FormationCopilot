using Microsoft.EntityFrameworkCore;

namespace Entities
{
    // Add DBcontext class
    public class RentCarDbContext : DbContext
    {
        // Add DBset properties
        

        // Add a constructor that accepts DbContextOptions
        public RentCarDbContext(DbContextOptions<RentCarDbContext> options) : base(options)
        {
        }

        // Override on model creating
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Add model configurations
            // It's possible to define a configuration class for each entity
            // It's also possible to define the configuration here
            // It's also possible to define an extension to do data seeding
        }       
    }
}