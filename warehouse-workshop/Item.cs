namespace WarehouseWorkshop
{
    class Item
    {
        public string Name { get; }
        public decimal Price { get; }
        public decimal SupplierPrice { get; }

        public Item (string name, decimal price, decimal supplierPrice)
        {
            Name = name;
            Price = price;
            SupplierPrice = supplierPrice;
        }
    }
}