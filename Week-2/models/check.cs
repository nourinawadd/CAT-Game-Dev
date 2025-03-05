namespace Models { 
    public class Check : Payment {
        public string Name { get; set; }
        public string BankID { get; set; }
        
        public Check(double amount, string name, string bandId) : base (amount)
        {
            BankID = bandId;
            Name = name;
        }
    }
}