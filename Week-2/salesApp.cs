using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
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
                
                int choice = Convert.ToInt32(Console.ReadLine());

                switch(choice){
                    case 1: // DATA ENTRY
                        Console.WriteLine("1. Add New/Update/Delete Customer");
                        Console.WriteLine("2. Add New/Update/Delete Product in Stock");
                        Console.Write("Choose an option: ");
                        int subChoice = Convert.ToInt32(Console.ReadLine());
                        if (subChoice == 1) ManageCustomers(customers);
                        else if (subChoice == 2) ManageStock(stock);
                        break;

                    case 2: // SALES PROCESS
                        Console.WriteLine("1. Add Transaction");
                        Console.WriteLine("2. Update Order");
                        Console.WriteLine("3. Pay Order");
                        Console.Write("Choose an option: ");
                        int salesChoice = Convert.ToInt32(Console.ReadLine());
                        if (salesChoice == 1) AddTransaction(customers, stock, transactions);
                        else if (salesChoice == 2) UpdateOrder(transactions, stock);
                        else if (salesChoice == 3) PayOrder(transactions);
                        break;

                    case 3: // PRINT
                        Console.WriteLine("1. Print Customers");
                        Console.WriteLine("2. Print Stock Data");
                        Console.WriteLine("3. Print Transactions");
                        Console.Write("Choose an option: ");
                        int printChoice = Convert.ToInt32(Console.ReadLine());
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
            int choice = Convert.ToInt32(Console.ReadLine());
            
            switch (choice) {
                case 1: // ADD CUSTOMER
                    Console.WriteLine("1. Company");
                    Console.WriteLine("2. Person");
                    Console.Write("Enter type of customer: ");
                    int subchoice1 = Convert.ToInt32(Console.ReadLine());

                    switch(subchoice1) {
                        case 1: // ADD COMPANY
                            Console.Write("Enter company ID: ");
                            int cid = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Enter company name: ");
                            string? cname = Console.ReadLine();
                            Console.Write("Enter company phone number: ");
                            string? cphone = Console.ReadLine();
                            Console.Write("Enter company location: ");
                            string? clocation = Console.ReadLine();

                            customers.AddCustomer(new Company(cid, cphone, clocation, cname));
                            Console.WriteLine("Added company into system.");
                            break;
                        case 2: // ADD PERSON
                            Console.Write("Enter person ID: ");
                            int pid = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Enter person's full name: ");
                            string? pname = Console.ReadLine();
                            Console.Write("Enter person's phone number: ");
                            string? pphone = Console.ReadLine();
                            Console.Write("Enter person's billing address: ");
                            string? pbilling = Console.ReadLine();

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
                    int subchoice2 = Convert.ToInt32(Console.ReadLine());

                    switch(subchoice2){
                        case 1: // EDIT COMPANY
                            Console.Write("Enter company ID to edit: ");
                            int ncid = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Enter new company name: ");
                            string? ncname = Console.ReadLine();
                            Console.Write("Enter new company phone number: ");
                            string? ncphone = Console.ReadLine();
                            Console.Write("Enter new company location: ");
                            string? nclocation = Console.ReadLine();

                            customers.EditCustomer(ncid, ncphone, ncname, nclocation);
                            Console.WriteLine("Edited company in system.");
                            break;
                        case 2: // EDIT PERSON
                            Console.Write("Enter person ID to edit: ");
                            int npid = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Enter new person's full name: ");
                            string? npname = Console.ReadLine();
                            Console.Write("Enter new person's phone number: ");
                            string? npphone = Console.ReadLine();
                            Console.Write("Enter new person's billing address: ");
                            string? npbilling = Console.ReadLine();

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
                    int deleteID = Convert.ToInt32(Console.ReadLine());

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
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice) {
                case 1: // ADD PRODUCT
                    Console.Write("Enter product ID: ");
                    int id = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter product name: ");
                    string? name = Console.ReadLine();
                    Console.Write("Enter product price: ");
                    double price = Convert.ToDouble(Console.ReadLine());                  
                    Console.Write("Enter product's stock quantity: ");
                    int quantity = Convert.ToInt32(Console.ReadLine());

                    stock.AddProduct(new Product(id, name, price, quantity));
                    Console.WriteLine("Product added into inventory.");
                    break;
                case 2: // EDIT PRODUCT
                    Console.Write("Enter product ID to edit: ");
                    int newID = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter new name: ");
                    string? newName = Console.ReadLine();
                    Console.Write("Enter new price: ");
                    double newPrice = Convert.ToDouble(Console.ReadLine());                  
                    Console.Write("Enter new stock quantity: ");
                    int newQuantity = Convert.ToInt32(Console.ReadLine());

                    stock.EditProduct(newID, newName, newPrice, newQuantity);
                    Console.WriteLine("Product edited in inventory.");
                    break;
                case 3: // DELETE PRODUCT
                    Console.Write("Enter product ID to delete: ");
                    int deleteID = Convert.ToInt32(Console.ReadLine());

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
            int customerId = Convert.ToInt32(Console.ReadLine());
            Customer customer = customers.SearchCustomers(customerId);
            if (customer == null) {
                Console.WriteLine("Customer not found.");
                return;
            }

            Console.Write("Enter order status (New/Hold/Paid/Cancelled): ");
            if (!Enum.TryParse(Console.ReadLine(), true, out Order.OrderStatus status)) {
                Console.WriteLine("Invalid status.");
                return;
            }

            Order order = new Order(customerId, status);

            Console.Write("Enter product ID: ");
            int productId = Convert.ToInt32(Console.ReadLine());
            Product product = stock.SearchProduct(productId);
            if (product == null) {
                Console.WriteLine("Product not found.");
                return;
            }

            Console.Write("Enter quantity: ");
            int quantity = Convert.ToInt32(Console.ReadLine());
            if (quantity > product.StockQuantity) {
                Console.WriteLine("Not enough stock available.");
                return;
            }

            OrderItem item = new OrderItem(customerId, product, quantity);
            order.AddItem(item);

            Transaction transaction = new Transaction(customerId, status);
            transaction.AddOrder(order);
            transactions.Add(transaction);
            Console.WriteLine("Order placed successfully.");
        }

        public static void UpdateOrder(List<Transaction> transactions, Stock stock){
            Console.Write("Enter customer ID to update: ");
            int custId = Convert.ToInt32(Console.ReadLine());

            Transaction transaction = transactions.Find(t => t.CustomerID == custId);
            if (transaction == null) {
                Console.WriteLine("Order not found.");
                return;
            }

            Console.Write("Enter new order status (New/Hold/Paid/Cancelled): ");
            if (!Enum.TryParse(Console.ReadLine(), true, out Order.OrderStatus newStatus)) {
                Console.WriteLine("Invalid status.");
                return;
            }

            transaction.Order.Status = newStatus;

            Console.Write("Enter product ID: ");
            int productId = Convert.ToInt32(Console.ReadLine());
            Product product = stock.SearchProduct(productId);
            if (product == null) {
                Console.WriteLine("Product not found.");
                return;
            }

            Console.Write("Enter quantity: ");
            int quantity = Convert.ToInt32(Console.ReadLine());
            if (quantity > product.StockQuantity) {
                Console.WriteLine("Not enough stock available.");
                return;
            }
            
            var existingItem = transaction.Order.OrderItems.Find(i => i.Product.ProductID == productId);
            if (existingItem != null) {
                existingItem.UpdateQuantity(quantity);
                Console.WriteLine("Updated quantity in existing order item.");
            } else {
                OrderItem item = new OrderItem(custId, product, quantity);
                transaction.Order.AddItem(item);
                Console.WriteLine("Added new item to order.");
            }
        }

        public static void PayOrder(List<Transaction> transactions){
            Console.Write("Enter customer ID: ");
            int custId = Convert.ToInt32(Console.ReadLine());

            Transaction transaction = transactions.Find(t => t.CustomerID == custId);
            if (transaction == null) {
                Console.WriteLine("Transaction not found.");
                return;
            }
            if (transaction.Order.Status == Order.OrderStatus.Paid) {
                Console.WriteLine("Order is already paid.");
                return;
            }
            Console.WriteLine("1. Cash");
            Console.WriteLine("2. Credit");
            Console.WriteLine("3. Check");
            Console.Write("Choose an option: ");
            int subchoice = Convert.ToInt32(Console.ReadLine());
            switch(subchoice){
                case 1: // CASH
                    double cashAmount = transaction.GetTotalAmount();
                    Console.Write($"Enter cash value (total amount = {cashAmount:C2}): ");
                    double value = Convert.ToDouble(Console.ReadLine());

                    Cash cash = new Cash(cashAmount, value, custId);
                    transaction.AddPayment(cash);
                    break;       
                case 2: // CREDIT
                    double creditAmount = transaction.GetTotalAmount();
                    Console.Write("Enter card number: ");
                    string? number = Console.ReadLine();
                    Console.Write("Enter expiry date (MM/YY): ");
                    DateOnly expiry;
                    while (!DateOnly.TryParse(Console.ReadLine(), out expiry)) {
                        Console.Write("Invalid date. Enter again (MM/YY): ");
                    }
                    Console.Write("Enter card type (Visa, Mastercard, etc.): ");
                    string? type = Console.ReadLine();

                    Credit credit = new Credit(creditAmount, number, expiry, type, custId);
                    transaction.AddPayment(credit);
                    break;
                case 3: // CHECK
                    double checkAmount = transaction.GetTotalAmount();
                    Console.Write("Enter account holder name: ");
                    string? name = Console.ReadLine();
                    Console.Write("Enter Bank ID: ");
                    string? bankId = Console.ReadLine();

                    Check check = new Check(checkAmount, name, bankId, custId);
                    transaction.AddPayment(check);
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
            transaction.Order.Status = Order.OrderStatus.Paid;
            Console.WriteLine("Order marked as paid.");
        }

        public static void PrintTransactions(List<Transaction> transactions){
            if (transactions.Count == 0) {
                Console.WriteLine("No transactions available.");
                return;
            }
            foreach (var transaction in transactions) {
                Console.WriteLine(transaction);
            }
        }
    }  
