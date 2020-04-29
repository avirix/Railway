using Railway.Models.Entities;

using Microsoft.EntityFrameworkCore;

namespace Railway.Models.Database
{
    public sealed class IteaDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<LoginHistory> Logins { get; set; }

        public IteaDbContext(DbContextOptions<IteaDbContext> options) : base(options)
        {
            //ChangeTracker.AutoDetectChangesEnabled = false;
            //Database.AutoTransactionsEnabled = false;
            //ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
        }
    }
}
