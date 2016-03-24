using System;
class TravellerBob
{
    static void Main()
    {
        
        string leap = Console.ReadLine();
        int contract = int.Parse(Console.ReadLine());
        int family = int.Parse(Console.ReadLine());

        
        int contractTravels = contract * (4 * 3);
        int familyTravels = (2 * 2) * family;
        double normalTravels = (((12 - contract - family) * 12) * 3 / 5.0);

        double totalTravels = contractTravels + familyTravels + normalTravels;

        
        if (leap == "leap")
        {
            totalTravels = totalTravels * 1.05;
        }

        
        Console.WriteLine((int)totalTravels);
    }
}
