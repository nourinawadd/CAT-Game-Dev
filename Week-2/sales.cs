using System;
using System.Collections.Generic;

namespace Tasks{
    class MainClass{
        public static void Main(string[] args){
            Console.WriteLine("Hey");
        }
    }

    class Stock {
        public static int productCount = 0;
        private List<Product> products = new List<Product>();

        public void AddProduct(Product product){
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
        public void DeleteProduct(Product product){
            products.Remove(product);
        }
        
    }

    class Customer {

    }

    class Product {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int StockQuantity { get; set; }

        public override string ToString()
        {
            return $"ID: {ProductID}, Name: {Name}, Price: {Price:C}, Stock: {StockQuantity}";
        }
    }

    class Order {

    }

    class OrderItem {

    }

    class Payment {

    }

    class Transaction {

    }
}