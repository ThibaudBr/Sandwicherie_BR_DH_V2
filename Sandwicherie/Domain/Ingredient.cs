namespace Sandwicherie.domain;

public class Ingredient
{
    public string Name { get; }

    public double Amount { get; }

    public int QuantityInGrammes { get; }
    
    private Ingredient(string name, double amount, int quantityInGrammes)
    {
        this.Name = name;
        this.Amount = amount;
        this.QuantityInGrammes = quantityInGrammes;
    }

    public static Ingredient Of(string name, int amount, int quantityInGrammes)
    {
        return new Ingredient(name, amount, quantityInGrammes);
    } 
}
