using ComedyEvents.Models;
using Microsoft.EntityFrameworkCore;

namespace ComedyEvents.DATA
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Comedian> Comedians { get; set; } = default!;
        public DbSet<Event> Events { get; set; } = default!;
        public DbSet<Gig> Gigs { get; set; } = default!;
        public DbSet<Venue> Venues { get; set; } = default!;
    }
}