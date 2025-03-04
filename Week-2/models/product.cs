public class Product
    {
        public int ProductID { get; set; }
        public required string Name { get; set; }
        public double Price { get; set; }
        public int StockQuantity { get; set; }
        public override string ToString()
        {
            return $"ID: {ProductID}, Name: {Name}, Price: {Price:C}, Stock: {StockQuantity}";
        }
    }