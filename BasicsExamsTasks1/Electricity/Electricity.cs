using System;


namespace _07
{
    class Program
    {
        static void Main(string[] args)
        {
            int floor = int.Parse(Console.ReadLine());
            int flats = int.Parse(Console.ReadLine());
            DateTime time = DateTime.Parse(Console.ReadLine());
            int sumWatts;
            double lapm = 100.53;
            double computer = 125.90;

            
            
            if (time.Hour > 14.00 && time.Hour < 18.59)
            {
                double noonConsumption = 2 * lapm + 2 * computer;
                sumWatts = (int)(noonConsumption * flats * floor);
            }
            else if ( time.Hour > 19.00 && time.Hour < 23.59)
            {
               double afternoonConsumption  = lamp * 7 + computer * 6;
                sumWatts = (int)(afternoonConsumption * flats * floor);
            }
            else if(time.Hour > 0.00 && time.Hour < 8.59)
            {
                double eveningConsumption= lamp + computer * 8;
                sumWatts = (int)(eveningConsumption * flats * floor);
            }
            else
            {
                sumWatts = 0;
            }

            Console.WriteLine(sumWatts + "Watts");

        }
    }
}
