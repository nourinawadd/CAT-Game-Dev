namespace Models {
    public class Transaction {
        public int CustomerID { get; set; }
        public DateTime TransactionDate { get; private set; }
        public Order Order { get; private set; }
        public Payment Payment { get; private set; }

        public Transaction(int customerId, Order.OrderStatus status) {
            CustomerID = customerId;
            TransactionDate = DateTime.Now;
        }

        public void AddOrder(Order order) {
            Order = order;
        }

        public void AddPayment(Payment payment) {
            Payment = payment;
            UpdateOrderStatus();
        }

        public double GetTotalPaid() {
            return Payment.Amount;
        }

        public double GetTotalAmount() {
            return Order.OrderItems.Sum(item => item.SalePrice);
        }

        private void UpdateOrderStatus() {
            if (GetTotalPaid() >= GetTotalAmount()) {
                Order.Status = Order.OrderStatus.Paid;
            }
        }

        public override string ToString() {
            return $"Customer ID: {CustomerID}, Date: {TransactionDate}, " +
                   $"Total: {GetTotalAmount():C}, Paid: {GetTotalPaid():C}, Status: {Order.Status}";
        }
    }
}
