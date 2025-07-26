// Order.cs
public class Order {
    private List<Product> products = new List<Product>();
    private Customer customer;

    public Order(Customer customer) {
        this.customer = customer;
    }

    public void AddProduct(Product product) {
        products.Add(product);
    }

    public double GetTotalCost() {
        double total = products.Sum(p => p.GetTotalCost());
        total += customer.IsUSA() ? 5 : 35;
        return total;
    }

    public string GetPackingLabel() {
        return string.Join("\n", products.Select(p => p.GetPackingInfo()));
    }

    public string GetShippingLabel() {
        return $"{customer.GetName()}\n{customer.GetAddress().GetFullAddress()}";
    }
}