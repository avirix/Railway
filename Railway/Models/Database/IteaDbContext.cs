using Microsoft.EntityFrameworkCore;

using Railway.Models.Entities;

namespace Railway.Models.Database
{
    public sealed class IteaDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<LoginHistory> Logins { get; set; }

        public DbSet<Carriage> Carriages { get; set; }
        public DbSet<CarriageService> CarriageServices { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<Train> Trains { get; set; }
        public DbSet<Station> Stations { get; set; }

        public IteaDbContext(DbContextOptions<IteaDbContext> options) : base(options)
        {
            //ChangeTracker.AutoDetectChangesEnabled = false;
            //Database.AutoTransactionsEnabled = false;
            //ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
        }
    }
}
