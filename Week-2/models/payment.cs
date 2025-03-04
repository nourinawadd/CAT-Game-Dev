namespace Models { 
    public class Payment {
        public enum PaymentType {
            Credit,
            Cash,
            Check
        }

        public PaymentType Type { get; set; }
        public DateTime PaymentDate { get; set; }
        public decimal Amount { get; set; }
        
        public Payment(PaymentType type, decimal amount) {
            Type = type;
            Amount = amount;
            PaymentDate = DateTime.Now;
        }
    }
}