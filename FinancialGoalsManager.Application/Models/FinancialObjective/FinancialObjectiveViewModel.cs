

namespace FinancialGoalsManager.Application.Models.FinancialObjective
{
    public class FinancialObjectiveViewModel
    {
        public FinancialObjectiveViewModel(int id, string titulo, decimal valorTotal)
        {
            Id = id;
            Titulo = titulo;
            ValorTotal = valorTotal;
        }

        public int Id { get; set; }
        public string Titulo { get; set; }
        public decimal ValorTotal { get; set; }

        public static FinancialObjectiveViewModel FromEntity(FinancialGoalsManager.Entities.FinancialObjective entity)
            => new FinancialObjectiveViewModel(entity.Id, entity.Titulo, entity.ValorTotal);
    }
}
