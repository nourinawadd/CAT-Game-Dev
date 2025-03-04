public class Customers{
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