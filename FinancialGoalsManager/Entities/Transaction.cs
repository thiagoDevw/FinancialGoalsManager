namespace FinancialGoalsManager.Entities
{
    public class Transaction
    {
        public int Id { get; set; }
        public decimal Quantidade { get; set; }
        // public Enum (Deposito, Saque)
        public DateTime DataTransaçao { get; set; }
        public DateTime DataCriaçao { get; set; }
        public bool Deletado { get; set; }

    }
}
