using System;



namespace _16.Tic_Tac_Toe
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int startNumebr = int.Parse(Console.ReadLine());
            int power = 1;

            if ( x==0 && y == 0)
            {
                startNumebr += 0;
                power += 0;
            }
            else if( x==1 && y == 0)
            {
                startNumebr += 1;
                power += 1;
            }
            else if (x == 2 && y == 0)
            {
                startNumebr += 2;
                power += 2;
            }
            else if (x == 0 && y == 1)
            {
                startNumebr += 3;
                power += 3;
            }
            else if (x == 1 && y == 1)
            {
                startNumebr += 4;
                power += 4;
            }
            else if (x == 2 && y == 1)
            {
                startNumebr += 5;
                power += 5;
            }
            else if (x == 0 && y == 2)
            {
                startNumebr += 6;
                power += 6;
            }
            else if (x == 1 && y == 2)
            {
                startNumebr += 7;
                power += 7;
            }
            else if (x == 2 && y == 2)
            {
                startNumebr += 8;
                power += 8;
            }
            Console.WriteLine(Math.Pow(startNumebr,power));
        }

    }
}
