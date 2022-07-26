using Sandwicherie.adapter.tools;
using Sandwicherie.domain.dto;
namespace Sandwicherie.Application.Services;

public class CLIService
{
    private readonly OrderService _orderService;
    private readonly ParserOrderService _parserOrderService;
    private readonly PrintMenu _printMenu;
    public CLIService(OrderService orderService, ParserOrderService parserOrderService, PrintMenu printMenu)
    {
        _orderService = orderService;
        _parserOrderService = parserOrderService;
        _printMenu = printMenu;
    }

    public void GenerateOrder(string input)
    {
        var createOrderParsed = _parserOrderService.parseOrder(input);

        OrderDto orderDto = new OrderDto(createOrderParsed);

        _orderService.SaveOrder(orderDto);
    }

    public void printMenu()
    {
        _printMenu.PrintMenuToCli(_orderService.getMenu());
    }
}
