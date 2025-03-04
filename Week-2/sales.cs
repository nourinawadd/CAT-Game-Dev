using System;
using System.Collections.Generic;

namespace Tasks{
    class MainClass{
        public static void Main(string[] args){
            Console.WriteLine("Hey");
        }
    }

    class Stock
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

    class Product
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


    class Customer {
        public int CustomerID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }     

        public Customer(int id, string name, string email, string phone){
            CustomerID = id;
            Name = name;
            Email = email;
            PhoneNumber = phone;
        }
        public override string ToString()
        {
            return $"ID: {CustomerID}, Name: {Name}, Email: {Email}, PhoneNumber: {PhoneNumber}";
        }
    }

    class Customers{
        private List<Customer> customerList = new List<Customer>();
        public void AddCustomer(Customer customer){
            customerList.Add(customer);
        }
        public void DeleteCustomer(Customer customer){
            customerList.Remove(customer);
        }
        public void EditCustomer(int customerId, string newName, string newEmail, string newPhone){
            Customer customer = customerList.Find(c => c.CustomerID == customerId);
            if (customer != null)
            {
                customer.Name = newName;
                customer.Email = newEmail;
                customer.PhoneNumber = newPhone;
            }
            else
            {
                Console.WriteLine("Customer not found.");
            }
        }
        public void PrintCustomers(){
            Console.WriteLine("Customer list: ");
            foreach (var customer in customerList){
                Console.WriteLine(customer);
            }
        }
    }
    class Order {
        public int OrderNumber { get; private set; }
        public DateTime OrderDate { get; set; }
        public decimal TotalAmount { get; set; }
        public OrderStatus Status { get; set; }
        public enum OrderStatus {
            New,
            Hold,
            Paid,
            Cancelled
        }

        public Order(OrderStatus status, decimal totalAmount) {
            OrderNumber = new Random().Next(1, 100000);
            OrderDate = DateTime.Now;
            TotalAmount = totalAmount;
            Status = status;
        }

        public void UpdateOrder(OrderStatus newStatus) {
            Status = newStatus;
        }

        public void EditOrder(decimal newTotal){
            TotalAmount = newTotal;
        }

        public override string ToString()
        {
            return $"Order Number: {OrderNumber}, Date: {OrderDate}, Total: {TotalAmount:C}, Status: {Status}";
        }
    }

    class OrderItem {

    }

    class Payment {

    }

    class Transaction {

    }
}