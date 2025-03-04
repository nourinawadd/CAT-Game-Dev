namespace Models {
    public class Company : Customer {
            public string Location { get; set; }
            public string CompanyName { get; set; }

            public Company(int id, string phone, string location, string companyName) 
                : base(id, phone) 
            {
                Location = location;
                CompanyName = companyName;
            }

            public override void Print()
            {
                Console.WriteLine($"Company: {CompanyName}, Location: {Location}, Phone: {Phone}");
            }
        }
}