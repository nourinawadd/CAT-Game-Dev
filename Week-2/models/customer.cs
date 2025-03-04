public class Customer {
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