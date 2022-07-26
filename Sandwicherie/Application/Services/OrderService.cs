using Sandwicherie.adapter.Repository;
using Sandwicherie.adapter.tools;
using Sandwicherie.domain;
using Sandwicherie.domain.dto;
namespace Sandwicherie.Application.Services;

public class OrderService
{
   private readonly SandwichRepository _sandwichRepository;
   private readonly PrintOrder _printOrder;

   public OrderService(SandwichRepository sandwichRepository, PrintOrder printOrder)
   {
      this._printOrder = printOrder;
      this._sandwichRepository = sandwichRepository;
   }

   public void SaveOrder(OrderDto orderDto)
   {
      IDictionary<string, Sandwich> sandwiches = new Dictionary<string, Sandwich>();
      Price orderPrice = Price.Of(0);
        
      foreach (var orderSandwich in orderDto.Order)
      {
         var sandwich = _sandwichRepository.FindByName(orderSandwich.Value);
         sandwiches.Add(orderSandwich.Key, sandwich);
         orderPrice.Addition(sandwich.Price.Value);
      }
        

      Order order = Order.Of(sandwiches, orderPrice);

      _printOrder.PrintOrderToCLI(order);
   }

   public List<Sandwich> getMenu()
   {
      return _sandwichRepository.getAll();
   }
}
