using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.BabaTincheAirlines
{
    class babaTinche
    {
        static void Main(string[] args)
        {
            string[] firstInput = Console.ReadLine().Split();
            string[] secondInput = Console.ReadLine().Split();
            string[] thirdInput = Console.ReadLine().Split();

            
            int firstClassIncome = (Convert.ToInt32(firstInput[0]) - Convert.ToInt32(firstInput[1])) * 7000;
            firstClassIncome += (int)(Convert.ToInt32(firstInput[1]) * (7000 * 0.3));
            firstClassIncome += (int)(Convert.ToInt32(firstInput[2]) * (0.005 * 7000));

          
            int secondClassIncome = (Convert.ToInt32(secondInput[0]) - Convert.ToInt32(secondInput[1])) * 3500;
            secondClassIncome += (int)(Convert.ToInt32(secondInput[1]) * (3500 * 0.3));
            secondClassIncome += (int)(Convert.ToInt32(secondInput[2]) * (0.005 * 3500));

           
            int thirdClassIncome = (Convert.ToInt32(thirdInput[0]) - Convert.ToInt32(thirdInput[1])) * 1000;
            thirdClassIncome += (int)(Convert.ToInt32(thirdInput[1]) * (1000 * 0.3));
            thirdClassIncome += (int)(Convert.ToInt32(thirdInput[2]) * (0.005 * 1000));

           
            int totalIncome = firstClassIncome + secondClassIncome + thirdClassIncome;
            Console.WriteLine(totalIncome);
        }
      }
    }


