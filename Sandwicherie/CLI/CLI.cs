using Sandwicherie.adapter.tools;
using Sandwicherie.Application.Services;
namespace Sandwicherie.CLI;

public class Cli
{
    private readonly CLIService _cliService;
   
    public Cli(CLIService cliService)
    {
        _cliService = cliService;
    }
    
    public void Start()
    {
        string input = "";

        Console.WriteLine("Bienvenue A la Sandwhicheri Family");
        
        
        while(true)
        {
            Console.WriteLine("Quel est votre commande ? (patern: A Jambon_beurre, B Diepoi, ...");
            _cliService.printMenu();
            input = Console.ReadLine();
            try
            {
                _cliService.GenerateOrder(input);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error : " + e.Message);
            }
        }
    }
}
