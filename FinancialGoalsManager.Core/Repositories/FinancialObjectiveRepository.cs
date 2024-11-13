using FinancialGoalsManager.Entities;
using Microsoft.EntityFrameworkCore;

namespace FinancialGoalsManager.Repositories
{
    public class FinancialObjectiveRepository : IRepository<FinancialObjective>
    {
        private readonly FinancialGoalsDbContext _context;

        public FinancialObjectiveRepository(FinancialGoalsDbContext context)
        {
            _context = context;
        }

        public async Task<FinancialObjective> Create(FinancialObjective entity)
        {
            _context.FinancialObjectives.Add(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task Delete(int id)
        {
            var entity = await _context.FinancialObjectives.FindAsync(id);
            if (entity != null)
            {
                _context.FinancialObjectives.Remove(entity);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<FinancialObjective>> GetAllAsync()
        {
            return await _context.FinancialObjectives.ToListAsync();
        }

        public async Task<FinancialObjective> GetById(int id)
        {
            return await _context.FinancialObjectives.FindAsync(id);
        }

        public async Task Update(FinancialObjective entity)
        {
            _context.FinancialObjectives.Update(entity);
            await _context.SaveChangesAsync();
        }
    }
}
