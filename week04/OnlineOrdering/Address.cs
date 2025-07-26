// Address.cs
public class Address {
    private string street, city, state, country;

    public Address(string street, string city, string state, string country) {
        this.street = street;
        this.city = city;
        this.state = state;
        this.country = country;
    }

    public bool IsUSA() => country.ToLower() == "usa";

    public string GetFullAddress() => $"{street}\n{city}, {state}\n{country}";
}