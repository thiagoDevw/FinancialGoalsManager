﻿using FinancialGoalsManager.Entities;
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
