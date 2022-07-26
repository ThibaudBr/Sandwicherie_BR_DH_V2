namespace Sandwicherie.adapter.tools;

public class ParserOrderService
{
    public IDictionary<string, string> parseOrder(String orderInput)
    {
        IDictionary<string, string> orderMap = new Dictionary<string, string>();
        var split = orderInput.Split(',');
        foreach (var s in split)
        {
            var str = s.TrimStart();
            var clientName = str.Substring(0, str.IndexOf(' ') + 1);
            var sandwichName = str.Remove(0, str.IndexOf(' ') + 1);
            orderMap.Add(clientName, sandwichName);
        }

        return orderMap;
    } 
}
