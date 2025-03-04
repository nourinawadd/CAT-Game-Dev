public class Order {
        public int OrderNumber { get; private set; }
        public DateTime OrderDate { get; set; }
        public decimal TotalAmount { get; set; }
        public OrderStatus Status { get; set; }
        public enum OrderStatus {
            New,
            Hold,
            Paid,
            Cancelled
        }

        public Order(OrderStatus status, decimal totalAmount) {
            OrderNumber = new Random().Next(1, 100000);
            OrderDate = DateTime.Now;
            TotalAmount = totalAmount;
            Status = status;
        }

        public void UpdateOrder(OrderStatus newStatus) {
            Status = newStatus;
        }

        public void EditOrder(decimal newTotal){
            TotalAmount = newTotal;
        }

        public override string ToString()
        {
            return $"Order Number: {OrderNumber}, Date: {OrderDate}, Total: {TotalAmount:C}, Status: {Status}";
        }
    }