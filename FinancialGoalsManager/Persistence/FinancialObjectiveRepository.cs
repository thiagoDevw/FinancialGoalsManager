using FinancialGoalsManager.Entities;
using FinancialGoalsManager.Repositories;

namespace FinancialGoalsManager.Persistence
{
    public class FinancialObjectiveRepository : IRepository<FinancialObjective>
    {
        public Task<FinancialObjective> Create(FinancialObjective entity)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<FinancialObjective>> GetAllAsync()
        {
            throw new NotImplementedException();
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
