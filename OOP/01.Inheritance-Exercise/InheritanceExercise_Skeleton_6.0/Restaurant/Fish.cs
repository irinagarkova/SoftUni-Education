namespace Restaurant;

public class Fish : MainDish
{
    private const double DefaultGrams = 22;

    public Fish(string name, decimal price) : base(name, price, DefaultGrams)
    {
    }
}