using System;


namespace _08
{
    class Program
    {
        static void Main(string[] args)
        {
            int bundle1Packets = int.Parse(Console.ReadLine());
            int bundle2Packets = int.Parse(Console.ReadLine());
            int bundle3Packets = int.Parse(Console.ReadLine());
            int bundle4Packets = int.Parse(Console.ReadLine());
            int tableTops = int.Parse(Console.ReadLine());
            int tablesToBeMade = int.Parse(Console.ReadLine());
            int totalLegs = bundle1Packets * 1 + bundle2Packets * 2 + bundle3Packets * 3 + bundle4Packets * 4;
            int legsForATable = totalLegs / 4;
            double diff = Math.Abs(legsForATable - tablesToBeMade);
           
            
                if (legsForATable >tablesToBeMade)
                {
                    Console.WriteLine("legs ");
                }



            }
        }
    }


