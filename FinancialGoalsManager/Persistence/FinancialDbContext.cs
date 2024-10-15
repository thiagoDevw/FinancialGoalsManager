using FinancialGoalsManager.Controllers;
using Microsoft.EntityFrameworkCore;
using System.Transactions;

namespace FinancialGoalsManager.Persistence
{
    public class FinancialDbContext : DbContext
    {
        public DbSet<Boxes> Boxes { get; set; }
        public DbSet<Transaction> Transactions { get; set; }

        public FinancialDbContext(DbContextOptions<FinancialDbContext> options)
            : base (options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
