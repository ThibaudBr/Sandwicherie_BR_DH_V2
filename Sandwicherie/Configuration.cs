using Sandwicherie.adapter.Repository;
using Sandwicherie.adapter.tools;
using Sandwicherie.Application.Services;
namespace Sandwicherie;

public class Configuration
{
    public CLI.Cli Cli;
    
    public Configuration()
    {
        this.Cli = CLI();
    }
    public CLI.Cli CLI()
    {
        return new CLI.Cli(CliService());
    }

    public CLIService CliService()
    {
        return new CLIService(OrderService(), ParserOrderService(), PrintMenu());
    }
    public OrderService OrderService()
    {
        return new OrderService(SandwichRepository(), PrintOrder());
    }
    public PrintOrder PrintOrder()
    {
        return new PrintOrder();
    }
    public SandwichRepository SandwichRepository()
    {
        return new SandwichRepository();
    }

    public ParserOrderService ParserOrderService()
    {
        return new ParserOrderService();
    }

    public PrintMenu PrintMenu()
    {
        return new PrintMenu();
    }
}
