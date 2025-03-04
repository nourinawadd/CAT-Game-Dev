namespace Models {
    public class Product
        {
            public int ProductID { get; set; }
            public string Name { get; set; }
            public decimal Price { get; set; }
            public int StockQuantity { get; set; }

            public Product(int productID, string name, decimal price, int stockQuantity){
                ProductID = productID;
                Name = name;
                Price = price;
                StockQuantity = stockQuantity;
            }
            public override string ToString()
            {
                return $"ID: {ProductID}, Name: {Name}, Price: {Price:C}, Stock: {StockQuantity}";
            }
        }
}