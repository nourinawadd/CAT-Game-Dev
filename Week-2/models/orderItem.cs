namespace Models {
    public class OrderItem {
            public Product Product { get; set; }
            public int Quantity { get; set; }
            public decimal SalePrice { get; set; }

            public OrderItem(Product product, int quantity, decimal price) {
                Product = product;
                Quantity = quantity;
                SalePrice = price;
            }

            public static OrderItem operator ++(OrderItem item) {
                if (item.Quantity < item.Product.StockQuantity){
                    item.Quantity++;
                }
                return item;
            }
            public static OrderItem operator --(OrderItem item) {
                if (item.Quantity > 0){
                    item.Quantity--;
                }
                return item;
            }
            public static OrderItem operator +(OrderItem item, int n) {
                if ((item.Quantity + n) <= item.Product.StockQuantity){
                    item.Quantity += n;
                }
                return item;
            }
            public static OrderItem operator -(OrderItem item, int n) {
                if ((item.Quantity - n) >= 0){
                    item.Quantity -= n;
                }
                return item;
            }
        }
    }