using System;
using System.Collections.Generic;


namespace _05.Volleyball
{
    class Volleyball
    {
        static void Main(string[] args)
        {
            string year=Console.ReadLine();
            int holidays = int.Parse(Console.ReadLine());
            int hometownWeekends = int.Parse(Console.ReadLine());
            int yearWeekends = 48;
            int normalWeekends = yearWeekends - hometownWeekends;
            int weekendsNotAtWork = normalWeekends * 3/4;
            int sundayPlay = hometownWeekends;
            int holidaysPlay = holidays * 2 / 3;
            int totalPlay = sundayPlay + weekendsNotAtWork + holidaysPlay;
             
            if (year == "leap")
            {
                Console.WriteLine(Math.Round(totalPlay * 15 / 100.0 + totalPlay));
            }
            else
            {
                Console.WriteLine(totalPlay);
            }
                
        }
    }
}
