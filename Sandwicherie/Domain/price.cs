namespace Sandwicherie.domain;

public class Price
{
    public double Value { get; set; }

    private Price(double value)
    {
        this.Value = value;
    }

    public static Price Of(double value)
    {
        return new Price(value);
    }

    public void Addition(double value)
    {
        this.Value += value;
    }
}