using CloudPart1.Models;
using Microsoft.EntityFrameworkCore;

namespace CloudPart1.Data
{
    public class AplicationDBContext : DbContext
    {
        public AplicationDBContext(DbContextOptions<AplicationDBContext> options) : base(options) { }

        public DbSet<Event> Events { get; set; }

        public DbSet<Venue> Venues { get; set; }
        public DbSet<Booking> Bookings { get; set; }
    
    }
}
