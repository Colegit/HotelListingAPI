using Microsoft.EntityFrameworkCore;

namespace HotelListing_API.Models
{
    public class HotelListingDbContext : DbContext
    {
        public HotelListingDbContext(DbContextOptions<HotelListingDbContext> options) : base(options)
        {
            
        }

        //by defining a DbSet, you are instructing a new table to be built, with the title, and attributes based on your data model
        //entityframework based on your predefined primary/foreign keys in your data model, entity framework will automatically build that into the generated tables
        public DbSet<Country> Countries { get; set; }
        public DbSet<Hotel> Hotels { get; set; }
    }
}
