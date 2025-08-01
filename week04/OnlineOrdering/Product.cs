// Product.cs
public class Product {
    private string name, productId;
    private double price;
    private int quantity;

    public Product(string name, string productId, double price, int quantity) {
        this.name = name;
        this.productId = productId;
        this.price = price;
        this.quantity = quantity;
    }

    public double GetTotalCost() => price * quantity;
    public string GetPackingInfo() => $"{name} (ID: {productId})";
}