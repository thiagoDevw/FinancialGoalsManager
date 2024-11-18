using System.ComponentModel.DataAnnotations;

namespace FinancialGoalsManager.Entities
{
    public class FinancialObjective
    {
        public FinancialObjective(ICollection<Transaction> transacoes)
        {
            Transacoes = transacoes ?? new List<Transaction>();
        }

        public int Id { get; set; }

        [Required(ErrorMessage= "O título é obrigatório.")]
        [StringLength(100, ErrorMessage = "O título não pode ter mais de 100 caracteres.")]
        public string Titulo { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "A quantidade alvo deve ser positiva.")]
        public decimal QuantidadeAlvo { get; set; }

        public DateTime? Prazo { get; set; } // Opcional

        [Range(0, double.MaxValue, ErrorMessage = "A quantidade ideal de aporte deve ser positiva.")]
        public decimal? QuantidadeIdealAporteMensal { get; set; } // Opcional

        [Required]
        public ObjectiveStatus Status { get; set; } 
        public DateTime DataCriacao { get; set; }
        public bool Deletado { get; set; }

        // Valor total acumulado em transações
        public decimal ValorTotal => Transacoes?.Where(t => !t.Deletado).Sum(t => t.Tipo == TransactionType.Deposito ? t.Quantidade : -t.Quantidade) ?? 0;

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
