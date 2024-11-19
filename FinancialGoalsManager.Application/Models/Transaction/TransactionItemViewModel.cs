using FinancialGoalsManager.Entities;

namespace FinancialGoalsManager.Application.Models.Transaction
{
    public class TransactionItemViewModel
    {
        public int Id { get; set; }
        public decimal Quantidade { get; set; }
        public TransactionType Tipo { get; set; }
        public DateTime DataTransacao { get; set; }
        public DateTime DataCriacao { get; set; }
    }
}
