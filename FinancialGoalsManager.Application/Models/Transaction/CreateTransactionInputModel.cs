using FinancialGoalsManager.Entities;

namespace FinancialGoalsManager.Application.Models.Transaction
{
    public class CreateTransactionInputModel
    {
        public decimal Quantidade { get; set; }
        public TransactionType Tipo { get; set; }
        public DateTime DataTransacao { get; set; }
    }
}
