using Microsoft.EntityFrameworkCore;

namespace HotelListing_API.Models
{
    public class HotelListingDbContext : DbContext
    {
        public HotelListingDbContext(DbContextOptions<HotelListingDbContext> options) : base(options)
        {
            
        }

        public DbSet<Country> Countries { get; set; }
    }
}
