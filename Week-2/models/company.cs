namespace Models {
    public class Company : Customer {
            public string Location { get; set; }
            public string CompanyName { get; set; }

            public Company(int id, string name, string location, string companyName) 
                : base(id, name) 
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