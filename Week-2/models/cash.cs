namespace Models {
    public class Cash : Payment {
        public double CashValue { get; set; }
        
        public Cash(double amount, double value, int customerId) : base(amount, customerId) {
            CashValue = value;
        }
    }
}
