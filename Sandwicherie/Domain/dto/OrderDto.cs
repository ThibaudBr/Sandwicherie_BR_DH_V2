namespace Sandwicherie.domain.dto;

public class OrderDto
{
    public IDictionary<string, string> Order { get; }

    public OrderDto(IDictionary<string, string> order)
    {
        this.Order = order;
    } 
}
