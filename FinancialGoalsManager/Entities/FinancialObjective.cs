namespace FinancialGoalsManager.Entities
{
    public class FinancialObjective
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public decimal QuantidadeAlvo { get; set; }
        public DateTime Prazo { get; set; } // Opcional
        public decimal QuantIdealAporte { get; set; } // Opcional
        public Enum Enum { get; set; } // Em progresso, Completo, Cancelado, Pausado
        // Transações (Coleção de Transação)
        public DateTime DataCriacao { get; set; }
        public bool Deletado { get; set; }

    }
}
