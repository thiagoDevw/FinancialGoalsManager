using FinancialGoalsManager.Entities;
using Microsoft.VisualBasic;

namespace FinancialGoalsManager.Application.Models.FinancialObjective
{
    public class FinancialObjectiveItemViewModel
    {
        public FinancialObjectiveItemViewModel(int id, string titulo, decimal quantidadeAlvo, decimal? quantIdealAporte, DateTime? prazo, FinancialObjectiveStatus status, DateTime dataCriacao, decimal valorTotal)
        {
            Id = id;
            Titulo = titulo;
            QuantidadeAlvo = quantidadeAlvo;
            QuantIdealAporte = quantIdealAporte;
            Prazo = prazo;
            Status = status;
            DataCriacao = dataCriacao;
            ValorTotal = valorTotal;
        }

        public int Id { get; set; }
        public string Titulo { get; set; }
        public decimal QuantidadeAlvo { get; set; }
        public decimal? QuantIdealAporte { get; set; }
        public DateTime? Prazo { get; set; }
        public FinancialObjectiveStatus Status { get; set; }
        public DateTime DataCriacao { get; set; }
        public decimal ValorTotal { get; set; }

        public static FinancialObjectiveItemViewModel FromEntity(FinancialObjectiveItemViewModel entity) 
            => new FinancialObjectiveItemViewModel(entity.Id, entity.Titulo, entity.QuantidadeAlvo,
                entity.QuantIdealAporte, entity.Prazo, entity.Status, entity.DataCriacao,
                entity.ValorTotal);
    }
}
