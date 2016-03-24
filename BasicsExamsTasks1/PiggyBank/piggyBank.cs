using System;

namespace _12
{
    class piggyBank
    {
        static void Main(string[] args)
        {
            int priceTank = int.Parse(Console.ReadLine());
            int partyDays = int.Parse(Console.ReadLine());
            int normalDays = 30 - partyDays;
            int monthlySavings = normalDays * 2;
            int monthlyExpenses = partyDays * 5;
            int monthlyBalance = monthlySavings - monthlyExpenses;

            double totalMonthsRequired = priceTank / monthlyBalance;
            int result = (int)Math.Ceiling(totalMonthsRequired);
            int years = result / 12;
            int months = result % 12;
            Console.WriteLine("{0} years, {1} months", years, months);
           
            //delenieto s %  ?

           
          

        }
    }
}
