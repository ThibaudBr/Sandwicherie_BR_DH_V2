using System.Text;
using Sandwicherie.domain;
namespace Sandwicherie.adapter.tools;

public class PrintMenu
{
    // TODO: A changer par un autre Dto
    public void PrintMenuToCli(List<Sandwich> sandwiches)
    {
        Console.WriteLine("List of sandwich available:");

        sandwiches.ForEach(sandwich =>
        {
            Console.WriteLine(" - " + sandwich.Name + " : " + IngredientToString(sandwich.Ingredients));
        });
    }
    
    private string IngredientToString(List<Ingredient> ingredients)
    {
        StringBuilder result = new StringBuilder();
        ingredients.ForEach(ingredient =>
        {
            result.Append(ingredient.Name );
        });

        return result.ToString();
    }
}
