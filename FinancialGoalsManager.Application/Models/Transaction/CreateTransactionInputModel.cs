﻿using FinancialGoalsManager.Entities;
using System.ComponentModel.DataAnnotations;

namespace FinancialGoalsManager.Application.Models.Transaction
{
    public class CreateTransactionInputModel
    {
        [Range(0.01, double.MaxValue, ErrorMessage = "A quantidade deve ser um valor positivo.")]
        [RegularExpression(@"^\d+(\.\d{1,2})?$", ErrorMessage = "A quantidade deve ter no máximo duas casas decimais.")]
        public decimal Quantidade { get; set; }

        [Required(ErrorMessage = "O tipo de transação é obrigatório.")]
        public TransactionType Tipo { get; set; }

        [DataType(DataType.Date, ErrorMessage = "A data da transação deve ser válida.")]
        [Required(ErrorMessage = "A data da transação é obrigatória.")]
        public DateTime DataTransacao { get; set; }

        [Required(ErrorMessage = "O ID do objetivo financeiro é obrigatório.")]
        public int FinancialObjectiveId { get; set; }
    }
}
