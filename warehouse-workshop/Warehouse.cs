namespace WarehouseWorkshop
{
    class Warehouse
    {
        //properties
        public Dictionary<Item,int> Stock = new Dictionary<Item,int>();
        public List<Transaction>Transactions = new List<Transaction>();

        //methods
    
        public void BuyItemForStock(Item item, int numberOfItem)
        {
            if (!Stock.ContainsKey(item))
            {
                Stock[item] = 0;
            }
            Stock[item]+= numberOfItem; 

            Transaction transaction = new Transaction("supplyer", "warehouse" ,numberOfItem*item.SupplierPrice, DateTime.Now);
            Transactions.Add(transaction);
        }
    }
}