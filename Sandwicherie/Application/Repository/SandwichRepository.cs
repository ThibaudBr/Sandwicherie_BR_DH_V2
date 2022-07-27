using Sandwicherie.domain;
namespace Sandwicherie.adapter.Repository;

public class SandwichRepository
{
    private List<Sandwich> _sandwiches { get; }

    public SandwichRepository()
    {
        _sandwiches = new List<Sandwich>();
        InitialiseData();
    }

    public void add(Sandwich sandwich)
    {
        _sandwiches.Add(sandwich);
    }

    public List<Sandwich> getAll()
    {
        return _sandwiches;
    }

    public Sandwich FindByName(string inputName)
    {
        Sandwich result = null;
        foreach (var sandwich in _sandwiches)
        {
            if (sandwich.Name.ToLower().Trim().Replace(" ", "") == inputName.ToLower().Trim().Replace(" ", ""))
                result = sandwich;
        }
        
        if (result == null)
            throw new KeyNotFoundException("Aucun sandwich avec le nom : ( " + inputName + " )");
        else
            return result;
    }
    public void InitialiseData()
    {
        List<Ingredient> _ingredients = new List<Ingredient>();
        _ingredients.Add(Ingredient.Of("pain", 1, 500));
        _ingredients.Add(Ingredient.Of("tranche de jambon", 1, 100));
        _ingredients.Add(Ingredient.Of("beurre", 10, 1));

        _sandwiches.Add(Sandwich.Of("Jambon_beurre", _ingredients, Price.Of(3.5)));

        List<Ingredient> _ingredients2 = new List<Ingredient>();
        _ingredients2.Add(Ingredient.Of("pain", 1,500));
        _ingredients2.Add(Ingredient.Of("oeuf", 1, 50));
        _ingredients2.Add(Ingredient.Of("tomate", 1, 50));
        _ingredients2.Add(Ingredient.Of("tranche de poulet", 1, 100));
        _ingredients2.Add(Ingredient.Of("mayonnaise", 1, 10));
        _ingredients2.Add(Ingredient.Of("salade", 10, 100));

        _sandwiches.Add(Sandwich.Of("Poulet_Crudites", _ingredients2, Price.Of(5)));

        List<Ingredient> _ingredients3 = new List<Ingredient>();
        _ingredients3.Add(Ingredient.Of("pain", 1, 500));
        _ingredients3.Add(Ingredient.Of("thon", 1, 50));
        _ingredients2.Add(Ingredient.Of("tomate", 1, 50));
        _ingredients2.Add(Ingredient.Of("mayonnaise", 1,10));
        _ingredients2.Add(Ingredient.Of("salade", 10, 100));

        _sandwiches.Add(Sandwich.Of("Diepois", _ingredients3, Price.Of(4.5)));
    }
    
}
