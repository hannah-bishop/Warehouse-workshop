namespace WarehouseWorkshop
{
    class Transaction
    {
        public string Payer { get; }
        public string Payee { get; }
        public decimal Cost { get; }

        public DateTime Date { get; }

        public Transaction (string payee, string payer, decimal cost, DateTime date)
        {
            Payer = payer;
            Payee = payee;
            Cost = cost;
            Date = Date;
        }
    }
}