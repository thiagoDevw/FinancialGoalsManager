using FinancialGoalsManager.Entities;
using FinancialGoalsManager.Repositories;

namespace FinancialGoalsManager.Service
{
    public class FinancialObjectiveService
    {
        private readonly IRepository<FinancialObjective> _repository;

        public FinancialObjectiveService(IRepository<FinancialObjective> repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<FinancialObjective>> GetAllFinancialObjectives()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<FinancialObjective> GetFinancialObjectiveById(int id)
        {
            return await _repository.GetById(id);
        }

        public async Task<FinancialObjective> GetFinancialObjective(FinancialObjective obj)
        {
            return await _repository.Create(obj);
        }
    }
}
