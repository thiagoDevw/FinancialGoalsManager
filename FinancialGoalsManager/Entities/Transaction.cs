namespace FinancialGoalsManager.Entities
{
    public class Transaction
    {
        public int Id { get; set; }
        public decimal Quantidade { get; set; }
        public TransactionType Tipo { get; set; }
        public DateTime DataTransaçao { get; set; }
        public DateTime DataCriaçao { get; set; }
        public bool Deletado { get; set; }

        public int FinancialObjectiveIde {  get; set; }
        public FinancialObjective FinancialObjective { get; set; }

    }

    public enum TransactionType
    {
        Deposito,
        Saque
    }
}
