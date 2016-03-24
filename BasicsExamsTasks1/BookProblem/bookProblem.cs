using System;


namespace _13.BookProblem
{
    class bookProblem
    {
        static void Main(string[] args)
        {
            int bookPages = int.Parse(Console.ReadLine());
            int campingDays = int.Parse(Console.ReadLine());
            int pagesReadInANormalDay= int.Parse(Console.ReadLine());
            int normalDays = 30 - campingDays;                                                    
            int pagesReadForAMonth = normalDays * pagesReadInANormalDay;
            double monthsNeeded = bookPages / pagesReadForAMonth;
            int result =(int)Math.Ceiling(monthsNeeded);
            int years = result / 12;
            double months = result % 12;
            Console.WriteLine("{0} years,{1} months",years,months);
            if (campingDays== 30 || pagesReadInANormalDay == 0)
            {
                Console.WriteLine("never");
            }
        }
    }
}
//na tretiq primer se poluchava 0 years,0 months,
// a v otgovora e 0 years ,1 months ????????