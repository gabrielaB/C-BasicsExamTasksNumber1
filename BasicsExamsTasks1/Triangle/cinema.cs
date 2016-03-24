using System;


namespace _03.Triangle
{
    class cinema
    {
        static void Main(string[] args)
        {
            string projection = Console.ReadLine();
            double premiere = 12.00;
            double normal = 7.5;
            double discount = 5.00;
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());
            double sizeOfTheHall = rows * cols;
            if (projection == "premiere")
            {
                Console.WriteLine("{0:F2} leva ",premiere * sizeOfTheHall);
            }
           else if (projection == "normal")
            {
                Console.WriteLine("{0:F2} leva" ,normal * sizeOfTheHall);
            }
            else
            {
                Console.WriteLine("{0:F2} leva " , discount * sizeOfTheHall);
            }
        }
    }
}
