namespace WarehouseWorkshop
{
    class Report
    {
        public void GenerateReport(Warehouse warehouse, CustomerBasket customerBasket)
        {
            using StreamWriter file = new("Report.txt", append: true);
            file.WriteLineAsync("Stock");
            foreach(KeyValuePair<Item,int> pair in warehouse.Stock)
            {
                file.WriteLine($"{pair.Key.Name} : {pair.Value}" );
            }
            file.WriteLineAsync("Transactions");
            foreach(Transaction transaction in warehouse.Transactions)
            {
                file.WriteLine($"---------\n Payer : {transaction.Payer} \n Payee : {transaction.Payee} \n Date and Time : {transaction.Date} \n Amount : {transaction.Cost}" );
            }
        }
    }
}