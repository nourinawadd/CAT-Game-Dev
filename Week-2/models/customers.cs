namespace Models {
    public class Customers
    {
        public int Count { get; private set; }
        private List<Customer> customerList = new List<Customer>();

        public void AddCustomer(Customer customer)
        {
            customerList.Add(customer);
            Count++;
        }

        public void EditCustomer(int id, string newPhone)
        {
            var customer = customerList.Find(c => c.CustomerID == id);
            if (customer != null)
            {
                customer.Phone = newPhone;
            }
        }

        public void DeleteCustomer(int id)
        {
            var customer = customerList.Find(c => c.CustomerID == id);
            if (customer != null)
            {
                customerList.Remove(customer);
                Count--;
            }
        }

        public void Print()
        {
            Console.WriteLine($"Total Customers: {Count}");
            foreach (var customer in customerList)
            {
                customer.Print();
            }
        }

        public Customer SearchCustomers(int id){
            return customerList.Find(c => c.CustomerID == id);
        }
    }
}