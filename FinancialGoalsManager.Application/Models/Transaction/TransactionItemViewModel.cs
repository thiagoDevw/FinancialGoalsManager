using FinancialGoalsManager.Entities;

namespace FinancialGoalsManager.Application.Models.Transaction
{
    public class TransactionItemViewModel
    {
        public TransactionItemViewModel(int id, decimal quantidade, TransactionType tipo, DateTime dataTransacao, DateTime dataCriacao)
        {
            Id = id;
            Quantidade = quantidade;
            Tipo = tipo;
            DataTransacao = dataTransacao;
            DataCriacao = dataCriacao;
        }

        public int Id { get; set; }
        public decimal Quantidade { get; set; }
        public TransactionType Tipo { get; set; }
        public DateTime DataTransacao { get; set; }
        public DateTime DataCriacao { get; set; }
    }
}
