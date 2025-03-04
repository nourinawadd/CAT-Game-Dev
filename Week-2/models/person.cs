namespace Models {
    public class Person : Customer {
            public string BillingAddress { get; set; }
            public string FullName { get; set; }

            public Person(int id, string phone, string billingAddress, string fullName) 
                : base(id, phone) 
            {
                BillingAddress = billingAddress;
                FullName = fullName;
            }

            public override void Print()
            {
                Console.WriteLine($"Person: {FullName}, Billing Address: {BillingAddress}, Phone: {Phone}");
            }
        }
}