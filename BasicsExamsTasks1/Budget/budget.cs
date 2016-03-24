using System;

namespace Budget
{
    class budget
    {
        static void Main(string[] args)
        {
            int amountPerMonth = int.Parse(Console.ReadLine());
            int goOutWeekdays = int.Parse(Console.ReadLine());
            int hometownWeekends = int.Parse(Console.ReadLine());
            int moneyForGoingOut =(int)Math.Floor((3 / 100.0) * amountPerMonth * goOutWeekdays);
            int moneyForWeekDays = 22 * 10 + moneyForGoingOut;
            int moneyForWeekEnds = (4 - hometownWeekends) * 40;
            int rent = 150;
            int total = (moneyForWeekDays + moneyForWeekEnds + rent);
            Console.WriteLine("total {0}",total);
            
            int difference = Math.Abs(amountPerMonth - total);

            if (total > amountPerMonth)
            {
                Console.WriteLine("No,not enough {0}",difference);
            }
            else if (amountPerMonth > total)
            {
                Console.WriteLine("Yes,leftover {0}",difference);
            }
            else if ( amountPerMonth == total)
            {
                Console.WriteLine("Exact budget");
            }
         
                               
        }
    }
}
