using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment generate = new Assignment();

        Card RedcliffMessenger = generate.RedcliffMessenger();
        RedcliffMessenger.DisplayCard();

        Card RedcliffDecimate = generate.RedcliffDecimate();
        RedcliffDecimate.DisplayCard();
    }
}
