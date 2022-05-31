namespace WarehouseWorkshop
{
    class CustomerBasket
    {
        public Dictionary<Item,int> customerBasket = new Dictionary<Item,int>();
        private decimal totalBasketCost;
        public int customerID { get; }

        public decimal GetTotalBasketCost()
        {
            totalBasketCost =0;
            foreach(KeyValuePair<Item,int> pair in customerBasket)
            {
                totalBasketCost+= pair.Key.Price*pair.Value;
            }
            return totalBasketCost;
        }

        public void AddItemToBasket(Item item, int numberOfItem, Warehouse warehouse)
        {
            if (numberOfItem <= warehouse.Stock[item]){
                customerBasket[item] = numberOfItem;
            }
            else
            {
                Console.WriteLine($"There are less than {numberOfItem} {item.Name} in stock ");
            }
            
        }

        public void BuyProductsInBasket(Warehouse warehouse, int customerID)
        {
            foreach(KeyValuePair<Item,int> pair in customerBasket)
            {
                warehouse.Stock[pair.Key] -= customerBasket[pair.Key];
            }

            Transaction transaction = new Transaction("warehouse", customerID.ToString() ,GetTotalBasketCost(), DateTime.Now);
            warehouse.Transactions.Add(transaction);
            customerBasket.Clear();

        }
    }
}