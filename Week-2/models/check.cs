namespace Models {
    public class Check : Payment {
        public string Name { get; set; }
        public string BankID { get; set; }
        
        public Check(double amount, string name, string bankId, int customerId) 
            : base(amount, customerId) {
            BankID = bankId;
            Name = name;
        }
    }
}
