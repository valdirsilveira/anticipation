using api.Models.EntityModel;
using Microsoft.EntityFrameworkCore;

namespace api.Infrastructure
{
    public class ApiDbContext : DbContext
    {
        public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options)
        {
        }

        public DbSet<Anticipation> Anticipations { get; set; }
        public DbSet<AnticipationStatus> AnticipationStatus { get; set; }
        public DbSet<Transaction> Transactions { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Anticipation>().Map();
            builder.Entity<AnticipationStatus>().Map();
            builder.Entity<Transaction>().Map();
        }
    }
}
