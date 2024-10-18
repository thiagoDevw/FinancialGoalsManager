namespace FinancialGoalsManager.Entities
{
    public class FinancialObjective
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public decimal QuantidadeAlvo { get; set; }
        public DateTime? Prazo { get; set; } // Opcional
        public decimal? QuantIdealAporte { get; set; } // Opcional
        public ObjectiveStatus Status { get; set; } 
        public DateTime DataCriacao { get; set; }
        public bool Deletado { get; set; }

        // Valor total acumulado em transações
        public decimal ValorTotal { get; set; }

        // Coleção de transações
        public ICollection<Transaction> Transacoes { get; set; }

    }

    public enum ObjectiveStatus
    {
        EmProgresso,
        Completo,
        Cancelado,
        Pausado
    }
}
