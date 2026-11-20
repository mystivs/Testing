using System;

public class Action : Support
{
    public int BoardRequirement { get; set; } = -1;
    public int HandRequirement { get; set; } = -1;
    public int Cost { get; set; }

    public int CostModifier { get; set; } = -1;
    public int AssistPower { get; set; } = -1;
    public int AssistHealth { get; set; } = -1;

    public void DisplayAction()
    {

        Console.WriteLine($"Name: {Team}{Name}");
        Console.WriteLine($"Power: {Power}");
        Console.WriteLine($"Health: {Health}");
       Console.WriteLine($"Card effect: {EffectDesc}");
    }
}
