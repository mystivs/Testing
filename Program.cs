using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment generate = new Assignment();

        Card RedcliffMessenger = generate.RedcliffMessenger();
        RedcliffMessenger.DisplayCard();

        Action RedcliffRise = generate.RedcliffRise();
        RedcliffRise.DisplayCard();
    }
}
