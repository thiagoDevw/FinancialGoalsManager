using System.ComponentModel.DataAnnotations;

namespace FinancialGoalsManager.Application.Models.FinancialObjective
{
    public class CreateFinancialObjectiveInputModel
    {
        [Required(ErrorMessage = "O título do objetivo é obrigatório.")]
        [MaxLength(100, ErrorMessage = "O título pode ter no máximo 100 caracteres.")]
        public string Titulo { get; set; }

        [Required(ErrorMessage = "A quantidade alvo é obrigatória.")]
        [Range(0.01, double.MaxValue, ErrorMessage = "A quantidade alvo deve ser positiva.")]
        public decimal QuantidadeAlvo {  get; set; }

        [Range(0.01, double.MaxValue, ErrorMessage = "A quantidade ideal de aporte deve ser positiva.")]
        public decimal? QuantidadeIdealAporteMensal { get; set; }

        [DataType(DataType.Date, ErrorMessage = "A data deve ser uma data válida.")]
        public DateTime? Prazo { get; set; }

        [Required(ErrorMessage = "O status do objetivo financeiro é obrigatório.")]
        public FinancialObjectiveStatus Status { get; set; }
    }

    public enum FinancialObjectiveStatus
    {
        EmProgresso,
        Completo,
        Cancelado,
        Pausado
    }
}
