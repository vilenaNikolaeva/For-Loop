using System;

namespace Odd_Or_Even_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            double oddSum = 0;
            double oddMin = double.MaxValue;
            double oddMax = double.MinValue;
            double evenSum = 0;
            double evenMin = double.MaxValue;
            double evenMax = double.MinValue;

            for (int i = 0; i < num; i++)
            {
                double current = double.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    oddSum += current;
                    if (current < oddMin)
                    {
                        oddMin = current;
                    }
                    if (current > oddMax)
                    {
                        oddMax = current;
                    }
                }
                else if (1 % 2 == 1)
                {
                    evenSum += current;
                    if (current < evenMin)
                    {
                        evenMin = current;
                    }
                    if (current > evenMax)
                    {
                        evenMax = current;
                    }
                }
            }
            Console.WriteLine($"OddSum={oddSum:f2},");
            if (oddSum == 0)
            {
                Console.WriteLine($"OddMin=No,");
            }
            else
            {
                Console.WriteLine($"OddMin={oddMin:f2},");
            }
            if (oddSum == 0)
            {
                Console.WriteLine($"OddMax=No,");
            }
            else
            {
                Console.WriteLine($"OddMax={oddMax:f2},");
            }

            Console.WriteLine($"EvenSum={evenSum:f2},");
            if (evenSum == 0)
            {
                Console.WriteLine($"EvenMin=No,");
            }
            else
            {
                Console.WriteLine($"EvenMin={evenMin:f2},");
            }
            if (evenSum == 0)
            {
                Console.WriteLine($"EvenMax=No");
            }
            else
            {
                Console.WriteLine($"EvenMax={evenMax:f2}");
            }
        }
    }
}
