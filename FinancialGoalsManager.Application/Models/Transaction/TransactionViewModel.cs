using FinancialGoalsManager.Entities;

namespace FinancialGoalsManager.Application.Models.Transaction
{
    public class TransactionViewModel
    {
        public int Id { get; set; }
        public decimal Quantidade { get; set; }
        public TransactionType Tipo { get; set; }

    }
}
