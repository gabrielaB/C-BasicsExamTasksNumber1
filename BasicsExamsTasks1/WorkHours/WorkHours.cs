using System;

namespace _04.WorkHours


{
    class Program
    {
        static void Main(string[] args)
        {
        int requiredHours = int.Parse(Console.ReadLine());
        int normalWorkingDays = int.Parse(Console.ReadLine());
        double biking = normalWorkingDays *0.1;
        double workingDays = normalWorkingDays - biking;
        double workingHours = workingDays * 12;
        int productivityPercent = int.Parse(Console.ReadLine());
            
           
        double efficientWorkHours = Math.Floor(workingHours *( productivityPercent/ 100.0));
        double difference = efficientWorkHours - requiredHours;
            if ( efficientWorkHours < requiredHours)
            {
                Console.WriteLine("No");
                
            }
            else
            {
                Console.WriteLine("Yes");
            }
            Console.WriteLine(difference);
       
        }


        }
    }
  


