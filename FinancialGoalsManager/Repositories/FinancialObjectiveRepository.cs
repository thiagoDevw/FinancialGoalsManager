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

        public Task<FinancialObjective> Create(FinancialObjective entity)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<FinancialObjective>> GetAllAsync()
        {
            return await _context.FinancialObjectives.ToListAsync();
        }

        public Task<FinancialObjective> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task Update(FinancialObjective entity)
        {
            throw new NotImplementedException();
        }
    }
}
