namespace Sandwicherie.domain;

public class Order
{
    public IDictionary<string, Sandwich> OrderSandwiches { get; }
    
    public Price OrderPrice { get; }
    private Order(IDictionary<string, Sandwich> orderSandwiches, Price totalPrice)
    {
        this.OrderSandwiches = orderSandwiches;
        this.OrderPrice = totalPrice;
    }

    public static Order Of(IDictionary<string, Sandwich> sandwiches, Price totalPrice)
    {
        return new Order(sandwiches, totalPrice);
    }
}
