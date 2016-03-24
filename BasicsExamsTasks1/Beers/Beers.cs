using System;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        int stacks = 0;
        int beers = 0;

        while (input != "End")
        {
            string[] splitInput = input.Split();

            int ammount = int.Parse(splitInput[0]);
            string type = splitInput[1];

            if (type == "beers")
            {
                beers += ammount;
            }
            else if(type == "stacks")
            {
                stacks += ammount;
            }

            input = Console.ReadLine();
        }

        stacks += beers / 20;
        beers = beers % 20;

        Console.WriteLine("{0} stacks + {1} beers", stacks, beers);
    }
}