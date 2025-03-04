using System;
using System.Collections.Generic;
using Models;
class MainClass{
        public static void Main(string[] args){
            Stock stock = new Stock();
            Customers customers = new Customers();
            List<Transaction> transactions = new List<Transaction>();

            while(true)
            {
                Console.WriteLine("Sales Order Application");
                Console.WriteLine("1. Data Entry");
                Console.WriteLine("2. Sales Process");
                Console.WriteLine("3. Print");
                Console.WriteLine("4. Exit");
                Console.Write("Choose an option: ");
                
                int choice = int.Parse(Console.ReadLine());

                switch(choice){
                    case 1:
                        // data entry
                        Console.WriteLine("1. Add New/Update/Delete Customer");
                        Console.WriteLine("2. Add New/Update/Delete Product in Stock");
                        Console.Write("Choose an option: ");
                        int subChoice = int.Parse(Console.ReadLine());
                        if (subChoice == 1) ManageCustomers(customers);
                        else if (subChoice == 2) ManageStock(stock);
                        break;

                    case 2:
                        // sales process
                        Console.WriteLine("1. Add Transaction");
                        Console.WriteLine("2. Update Order");
                        Console.WriteLine("3. Pay Order");
                        Console.Write("Choose an option: ");
                        int salesChoice = int.Parse(Console.ReadLine());
                        if (salesChoice == 1) AddTransaction(customers, stock, transactions);
                        else if (salesChoice == 2) UpdateOrder(transactions);
                        else if (salesChoice == 3) PayOrder(transactions);
                        break;

                    case 3:
                        // print
                        Console.WriteLine("1. Print Customers");
                        Console.WriteLine("2. Print Stock Data");
                        Console.WriteLine("3. Print Transactions");
                        Console.Write("Choose an option: ");
                        int printChoice = int.Parse(Console.ReadLine());
                        if (printChoice == 1) customers.PrintCustomers();
                        else if (printChoice == 2) Stock.PrintStock(stock);
                        else if (printChoice == 3) PrintTransactions(transactions);
                        break;

                    case 4:
                        // exit
                        Console.WriteLine("Goodbye!");
                        return;
                    default:
                        // invalid
                        Console.WriteLine("Invalid option, try again.");
                        break;
                }
            }
        }
        public static void ManageCustomers(Customers customers){
            Console.WriteLine("1. Add Customer");
            Console.WriteLine("2. Edit Customer");
            Console.WriteLine("3. Delete Customer");
            Console.Write("Choose an option: ");
            int choice = int.Parse(Console.ReadLine());
            
            switch (choice) {
                case 1: // ADD CUSTOMER
                    Console.Write("Enter customer ID: ");
                    int id = int.Parse(Console.ReadLine());
                    Console.Write("Enter customer's name: ");
                    string name = Console.ReadLine();
                    Console.Write("Enter customer's email: ");
                    string email = Console.ReadLine();
                    Console.Write("Enter customer's phone number: ");
                    string number = Console.ReadLine();

                    customers.AddCustomer(new Customer(id, name, email, number));
                    Console.WriteLine("Added customer into system.");
                    break;
                case 2: // EDIT CUSTOMER
                    Console.Write("Enter ID of customer to edit: ");
                    int newID = int.Parse(Console.ReadLine());
                    Console.Write("Enter new name: ");
                    string newName = Console.ReadLine();
                    Console.Write("Enter new email: ");
                    string newEmail = Console.ReadLine();
                    Console.Write("Enter new phone number: ");
                    string newNumber = Console.ReadLine();

                    customers.EditCustomer(newID, newName, newEmail, newNumber);
                    Console.WriteLine("Edited customer in system.");
                    break;
                case 3: // DELETE CUSTOMER
                    Console.Write("Enter customer ID to delete: ");
                    int deleteID = int.Parse(Console.ReadLine());

                    customers.DeleteCustomer(deleteID);
                    Console.WriteLine("Deleted customer in system");
                    break;
                default:
                    // invalid
                    break;
            }
        }

        public static void ManageStock(Stock stock){
            Console.WriteLine("1. Add Product");
            Console.WriteLine("2. Edit Product");
            Console.WriteLine("3. Delete Product");
            Console.Write("Choose an option: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice) {
                case 1: // ADD PRODUCT
                    Console.Write("Enter product ID: ");
                    int id = int.Parse(Console.ReadLine());
                    Console.Write("Enter product name: ");
                    string name = Console.ReadLine();
                    Console.Write("Enter product price: ");
                    double price = double.Parse(Console.ReadLine());                  
                    Console.Write("Enter product's stock quantity: ");
                    int quantity = int.Parse(Console.ReadLine());

                    stock.AddProduct(new Product(id, name, price, quantity));
                    Console.WriteLine("Product added into inventory.");
                    break;
                case 2: // EDIT PRODUCT
                    Console.Write("Enter product ID to edit: ");
                    int newID = int.Parse(Console.ReadLine());
                    Console.Write("Enter new name: ");
                    string newName = Console.ReadLine();
                    Console.Write("Enter new price: ");
                    double newPrice = double.Parse(Console.ReadLine());                  
                    Console.Write("Enter new stock quantity: ");
                    int newQuantity = int.Parse(Console.ReadLine());

                    stock.EditProduct(newID, newName, newPrice, newQuantity);
                    Console.WriteLine("Product edited in inventory.");
                    break;
                case 3: // DELETE PRODUCT
                    Console.Write("Enter product ID to delete: ");
                    int deleteID = int.Parse(Console.ReadLine());

                    stock.DeleteProduct(deleteID);
                    Console.WriteLine("Product deleted from inventory.");
                    break;
                default:
                    // invalid
                    break;
            }        
        }

        public static void AddTransaction(Customers customers, Stock stock, List<Transaction> transactions){

        }

        public static void UpdateOrder(List<Transaction> transactions){

        }

        public static void PayOrder(List<Transaction> transactions){

        }

        public static void PrintTransactions(List<Transaction> transactions){

        }
    }  
