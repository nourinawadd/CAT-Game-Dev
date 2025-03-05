namespace Models {    
    public class Order {
            public int CustomerID { get; set; } 
            public int OrderNumber { get; private set; }
            public DateTime OrderDate { get; set; }
            public decimal TotalAmount { get; private set; }
            public OrderStatus Status { get; set; }
            public enum OrderStatus {
                New,
                Hold,
                Paid,
                Cancelled
            }

            public List<OrderItem> OrderItems = new List<OrderItem>();

            public Order(int customerId, OrderStatus status) {
                CustomerID = customerId;
                OrderNumber = new Random().Next(1, 100000);
                OrderDate = DateTime.Now;
                Status = status;
            }

            public void AddItem(OrderItem item) {
                OrderItems.Add(item);
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
    }