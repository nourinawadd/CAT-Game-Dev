namespace Models {
    public class Transaction {
        public int CustomerID { get; private set; }
        public DateTime TransactionDate { get; private set; }
        public Order Order { get; private set; }
        public List<Payment> Payments = new List<Payment>();

        public Transaction(int customerId, Order.OrderStatus status) {
            CustomerID = customerId;
            TransactionDate = DateTime.Now;
            Order = new Order(customerId, status);
        }

        public void AddPayment(Payment payment) {
            Payments.Add(payment);
            UpdateOrderStatus();
        }

        public decimal GetTotalPaid() {
            return Payments.Sum(p => (decimal)p.Amount);
        }

        public decimal GetTotalAmount() {
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
