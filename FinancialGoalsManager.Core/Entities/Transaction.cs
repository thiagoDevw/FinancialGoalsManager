using FinancialGoalsManager.Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace FinancialGoalsManager.Entities
{
    public class Transaction : BaseEntity
    {
        public Transaction()
        {
            DataCriaçao = DateTime.Now;
            Tipo = TransactionType.Deposito;
        }

        public int Id { get; set; }

        [Range(0.01, double.MaxValue, ErrorMessage= "A quantidade deve ser um valor positivo.")]
        [RegularExpression(@"^\d+(\.\d{1,2})?$", ErrorMessage = "A quantidade deve ter no máximo duas casas decimais.")]
        public decimal Quantidade { get; set; }

        [Required(ErrorMessage = "O tipo de transação é obrigatório.")]
        public TransactionType Tipo { get; set; }

        [DataType(DataType.Date, ErrorMessage = "A data da transação deve ser válida.")]
        [Required(ErrorMessage = "A data da transação é obrigatória.")]
        public DateTime DataTransacao { get; set; }
        public DateTime DataCriaçao { get; set; } = DateTime.Now;
        public bool Deletado { get; set; }

        public int FinancialObjectiveId {  get; set; }
        public FinancialObjective FinancialObjective { get; set; }

    }

    public enum TransactionType
    {
        Deposito,
        Saque
    }
}
