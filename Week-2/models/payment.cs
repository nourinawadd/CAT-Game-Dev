namespace Models {
    public class Payment {
        public DateTime PaymentDate { get; set; }
        public double Amount { get; set; }
        public int CustomerID { get; set; }
        
        public Payment(double amount, int customerId) {
            Amount = amount;
            CustomerID = customerId;
            PaymentDate = DateTime.Now;
        }
    }
}
