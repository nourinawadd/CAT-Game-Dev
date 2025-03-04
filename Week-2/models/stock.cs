namespace Models {
    public class Stock
        {
            private List<Product> products = new List<Product>();
            public int Count => products.Count;
            public void AddProduct(Product product)
            {
                products.Add(product);
            }
            public void EditProduct(int productId, string newName, double newPrice, int newStockQuantity)
            {
                Product product = products.Find(p => p.ProductID == productId);
                if (product != null)
                {
                    product.Name = newName;
                    product.Price = newPrice;
                    product.StockQuantity = newStockQuantity;
                }
                else
                {
                    Console.WriteLine("Product not found.");
                }
            }
            public void DeleteProduct(int productId)
            {
                products.RemoveAll(p => p.ProductID == productId);
            }
            public int SearchProduct(int productId)
            {
                Product product = products.Find(p => p.ProductID == productId);
                return product != null ? product.StockQuantity : -1;
            }
            public static void PrintStock(Stock stock)
            {
                Console.WriteLine("Stock Inventory:");
                foreach (var product in stock.products)
                {
                    Console.WriteLine(product);
                }
            }
    }
}