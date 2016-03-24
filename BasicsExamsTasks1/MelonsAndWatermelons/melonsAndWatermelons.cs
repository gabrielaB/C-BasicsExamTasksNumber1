using System;


namespace _06
{
    class melonsAndWatermelons
    {
        static void Main(string[] args)
        {

            int startingDay = int.Parse(Console.ReadLine());
            int sequentialDays = int.Parse(Console.ReadLine());
           
            int melonSum = 0;
            int watermelonSum = 0;
            for (int i = startingDay; i < startingDay + sequentialDays; i++)
            {

                switch (i %7)                    
                {
                    case 1:
                        watermelonSum += 1;
                        break;
                    case 2:
                        melonSum += 2;
                        break;
                    case 3:
                        watermelonSum += 1;
                        melonSum += 1;
                        break;
                    case 4:
                        watermelonSum += 2;
                        break;
                    case 5:
                        watermelonSum += 2;
                        melonSum += 2;
                        break;
                    case 6:
                        watermelonSum += 1;
                        melonSum += 2;
                        break;
                    default:
                        break;
                }
            }
                int difference = Math.Abs(melonSum - watermelonSum);
                if ( melonSum > watermelonSum)
                {
                    Console.WriteLine("{0} more melons",difference);
                }
                else if ( watermelonSum > melonSum)
                {
                    Console.WriteLine("{0} more watermelons",difference);
                }
                else
                {
                    Console.WriteLine("The amount is equal");
                }

            }
            

            }
                
        }
    

