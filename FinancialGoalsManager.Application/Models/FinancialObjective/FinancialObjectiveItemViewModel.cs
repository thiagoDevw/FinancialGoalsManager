namespace FinancialGoalsManager.Application.Models.FinancialObjective
{
    public class FinancialObjectiveItemViewModel
    {

        public int Id { get; set; }
        public string Titulo { get; set; }
        public decimal QuantidadeAlvo { get; set; }
        public decimal? QuantIdealAporte { get; set; }
        public DateTime? Prazo { get; set; }
        public FinancialObjectiveStatus Status { get; set; }
        public DateTime DataCriacao { get; set; }
        public decimal ValorTotal { get; set; }
    }
}
