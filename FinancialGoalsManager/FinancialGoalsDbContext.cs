using FinancialGoalsManager.Entities;
using Microsoft.EntityFrameworkCore;

namespace FinancialGoalsManager
{
    public class FinancialGoalsDbContext : DbContext 
    {
        public FinancialGoalsDbContext(DbContextOptions<FinancialGoalsDbContext> options)
            : base(options) { }

        public DbSet<FinancialObjective> Objectives { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
    }
}
