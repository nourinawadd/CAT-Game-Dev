public class Transaction {
    public List<Order> Orders = new List<Order>();
    public List<Payment> Payments = new List<Payment>();

    public static Transaction operator +(Transaction transaction, (Order order, Payment payment) data){
        transaction.Orders.Add(data.order);
        transaction.Payments.Add(data.payment);
        return transaction;
    }

    public override string ToString() {
        string orderDetails = string.Join("\n", Orders);
        string paymentDetails = string.Join("\n", Payments);
        return $"Orders:\n {orderDetails} \nPayments:\n {paymentDetails}";
    }
}