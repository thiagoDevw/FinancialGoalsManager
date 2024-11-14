using FinancialGoalsManager.Entities;
using System.ComponentModel.DataAnnotations;

namespace FinancialGoalsManager.Application.Models.Transaction
{
    public class UpdateTransactionInputModel
    {
        [Range(0.01, double.MaxValue, ErrorMessage = "A quantidade deve ser um valor positivo.")]
        [RegularExpression(@"^\d+(\.\d{1,2})?$", ErrorMessage = "A quantidade deve ter no máximo duas casas decimais.")]
        public decimal Quantidade { get; set; }

        [Required(ErrorMessage = "O tipo de transação é obrigatório.")]
        public TransactionType Tipo { get; set; }

        [DataType(DataType.Date, ErrorMessage = "A data da transação deve ser válida.")]
        public DateTime DataTransacao { get; set; }
    }
}
