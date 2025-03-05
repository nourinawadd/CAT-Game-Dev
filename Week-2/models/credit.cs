namespace Models {
    public class Credit : Payment {
        public string CardNumber { get; set; }
        public DateOnly ExpiryDate { get; set; }
        public string CardType { get; set; }
        
        public Credit(double amount, string number, DateOnly expiry, string type, int customerId) 
            : base(amount, customerId) {
            CardType = type;
            ExpiryDate = expiry;
            CardNumber = number;
        }
    }
}
