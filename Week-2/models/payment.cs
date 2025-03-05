namespace Models { 
    public class Payment {
        public DateTime PaymentDate { get; set; }
        public double Amount { get; set; }
        
        public Payment(double amount) {
            Amount = amount;
            PaymentDate = DateTime.Now;
        }

        

    }
}