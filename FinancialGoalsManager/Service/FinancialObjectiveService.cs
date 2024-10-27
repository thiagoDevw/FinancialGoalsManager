﻿using FinancialGoalsManager.Entities;
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
    }
}