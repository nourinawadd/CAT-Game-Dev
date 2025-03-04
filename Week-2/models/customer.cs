namespace Models {
    public class Customer {
            public int CustomerID { get; set; }
            public string Phone { get; set; }   

            public Customer(int id, string phone){
                CustomerID = id;
                Phone = phone;
            }
            public virtual void Print()
            {
                Console.WriteLine($"Customer ID: {CustomerID}, Phone: {Phone}");
            }
        }
}