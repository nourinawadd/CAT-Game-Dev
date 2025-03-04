﻿using System;
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
                        if (printChoice == 1) customers.Print();
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
                    Console.WriteLine("1. Company");
                    Console.WriteLine("2. Person");
                    Console.Write("Enter type of customer: ");
                    int subchoice1 = int.Parse(Console.ReadLine());

                    switch(subchoice1) {
                        case 1: // ADD COMPANY
                            Console.Write("Enter company ID: ");
                            int cid = int.Parse(Console.ReadLine());
                            Console.Write("Enter company name: ");
                            string cname = Console.ReadLine();
                            Console.Write("Enter company phone number: ");
                            string cphone = Console.ReadLine();
                            Console.Write("Enter company location: ");
                            string clocation = Console.ReadLine();

                            customers.AddCustomer(new Company(cid, cphone, clocation, cname));
                            Console.WriteLine("Added company into system.");
                            break;
                        case 2: // ADD PERSON
                            Console.Write("Enter person ID: ");
                            int pid = int.Parse(Console.ReadLine());
                            Console.Write("Enter person's full name: ");
                            string pname = Console.ReadLine();
                            Console.Write("Enter person's phone number: ");
                            string pphone = Console.ReadLine();
                            Console.Write("Enter person's billing address: ");
                            string pbilling = Console.ReadLine();

                            customers.AddCustomer(new Person(pid, pphone, pbilling, pname));
                            Console.WriteLine("Added person into system.");
                            break;
                        default:
                            Console.WriteLine("Invalid choice.");
                            break;
                    }
                    break;

                case 2: // EDIT CUSTOMER
                    Console.WriteLine("1. Company");
                    Console.WriteLine("2. Person");
                    Console.Write("Enter type of customer: ");
                    int subchoice2 = int.Parse(Console.ReadLine());

                    switch(subchoice2){
                        case 1: // EDIT COMPANY
                            Console.Write("Enter company ID to edit: ");
                            int ncid = int.Parse(Console.ReadLine());
                            Console.Write("Enter new company name: ");
                            string ncname = Console.ReadLine();
                            Console.Write("Enter new company phone number: ");
                            string ncphone = Console.ReadLine();
                            Console.Write("Enter new company location: ");
                            string nclocation = Console.ReadLine();

                            customers.EditCustomer(ncid, ncphone, ncname, nclocation);
                            Console.WriteLine("Edited company in system.");
                            break;
                        case 2: // EDIT PERSON
                            Console.Write("Enter person ID to edit: ");
                            int npid = int.Parse(Console.ReadLine());
                            Console.Write("Enter new person's full name: ");
                            string npname = Console.ReadLine();
                            Console.Write("Enter new person's phone number: ");
                            string npphone = Console.ReadLine();
                            Console.Write("Enter new person's billing address: ");
                            string npbilling = Console.ReadLine();

                            customers.EditCustomer(npid, npphone, npname, npbilling);
                            Console.WriteLine("Edited person in system.");
                            break;
                        default:
                            Console.WriteLine("Invalid choice.");
                            break;
                    }
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
                    decimal price = decimal.Parse(Console.ReadLine());                  
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
                    decimal newPrice = decimal.Parse(Console.ReadLine());                  
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
            Console.Write("Enter customer ID: ");
            int customerId = int.Parse(Console.ReadLine());
            Customer customer = customers.SearchCustomers(customerId);
            if (customer == null) {
                Console.WriteLine("Customer not found.");
                return;
            }

            Console.Write("Enter product ID: ");
            int productId = int.Parse(Console.ReadLine());
            Product product = stock.SearchProduct(productId);
            if (product == null) {
                Console.WriteLine("Product not found.");
                return;
            }

            Console.Write("Enter quantity: ");
            int quantity = int.Parse(Console.ReadLine());
            if (quantity > product.StockQuantity) {
                Console.WriteLine("Not enough stock available.");
                return;
            }

            Console.WriteLine("Enter order status: (New/Hold/Paid/Cancelled)");
            Order.OrderStatus status = (Order.OrderStatus)Enum.Parse(typeof(Order.OrderStatus), Console.ReadLine(), true);

            Console.Write("Enter payment amount: ");
            decimal amount = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Enter payment type (Credit/Cash/Check): ");
            Payment.PaymentType type = (Payment.PaymentType)Enum.Parse(typeof(Payment.PaymentType), Console.ReadLine(), true);

            OrderItem item = new OrderItem(product, quantity, product.Price * quantity);
            Order order = new Order(status, amount);
            Payment payment = new Payment(type, amount);

            Transaction transaction = new Transaction();
            transaction += (order, payment);
            transactions.Add(transaction);

            Console.WriteLine("Transaction added successfully.");
        }

        public static void UpdateOrder(List<Transaction> transactions){

        }

        public static void PayOrder(List<Transaction> transactions){
        }

        public static void PrintTransactions(List<Transaction> transactions){

        }
    }  
