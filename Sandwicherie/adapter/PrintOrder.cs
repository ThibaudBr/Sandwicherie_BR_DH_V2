using Sandwicherie.domain;
namespace Sandwicherie.adapter.tools;

public class PrintOrder
{
    public void PrintOrderToCLI(Order order)
    {
        foreach (var orderSandwich in order.OrderSandwiches)
        {
            Console.WriteLine(orderSandwich.Key + " " + orderSandwich.Value.Name);
            foreach (var ingredient in orderSandwich.Value.Ingredients)
            {
                Console.WriteLine("\t - " + ingredient.Name+ " , qut: " + ingredient.Amount + ", en g: " + ingredient.QuantityInGrammes);
            }
        }
    }
}
