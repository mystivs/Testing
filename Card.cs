using System;

public class Card : Support
{
    public int Health { get; set; }
    public int Power { get; set; }
    public int Cost { get; set; }
    public int Rank { get; set; }

    public void DisplayCard()
    {
        Console.WriteLine($"Name: {Team}{Name}");
        Console.WriteLine($"Can heal: {CanHeal}");
        Console.WriteLine($"On cast effect: {OnCast}");
        Console.WriteLine($"Power: {Power}");
        Console.WriteLine($"Health: {Health}");
        Console.WriteLine($"Cost: {Cost}");
    }
}
