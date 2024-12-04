using FinancialGoalsManager.Entities;

namespace FinancialGoalsManager.Application.Models.Transaction
{
    public class TransactionViewModel
    {
        public TransactionViewModel(int id, decimal quantidade, TransactionType tipo)
        {
            Id = id;
            Quantidade = quantidade;
            Tipo = tipo;
        }

        public int Id { get; set; }
        public decimal Quantidade { get; set; }
        public TransactionType Tipo { get; set; }

        public static TransactionViewModel FromEntity(FinancialGoalsManager.Entities.Transaction entity) 
            => new TransactionViewModel(entity.Id, entity.Quantidade, entity.Tipo);

    }
}
