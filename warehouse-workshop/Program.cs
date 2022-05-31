namespace WarehouseWorkshop
{
    class Program
    {
        static void Main(string[] args)
        {

            Warehouse warehouse = new Warehouse();
            CustomerBasket customerbasket = new CustomerBasket();
            Report report = new Report();

            Item banana = new Item("banana" , 0.50m, 0.25m);
            warehouse.BuyItemForStock(banana,100);
            customerbasket.AddItemToBasket(banana,99,warehouse);
            customerbasket.BuyProductsInBasket(warehouse, 1234);
            foreach (Transaction transaction in warehouse.Transactions)
            {
                Console.WriteLine(transaction.Cost);
            }
            report.GenerateReport(warehouse, customerbasket);


        }
    }
}