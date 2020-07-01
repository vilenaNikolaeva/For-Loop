using System;

namespace Equal_Pairs
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int previousSum = 0;
            int diff = 0;
            int total = 0;

            for (int i = 0; i < n; i++)
            {
                if (i == 0)
                {
                    int num1 = int.Parse(Console.ReadLine());
                    int num2 = int.Parse(Console.ReadLine());
                    previousSum = num1 + num2;
                }
                else
                {
                    int secondPairs1 = int.Parse(Console.ReadLine());
                    int secondPairs2 = int.Parse(Console.ReadLine());
                    sum = secondPairs1 + secondPairs2;
                    total = Math.Abs(sum - previousSum);
                    if (total > diff)
                    {
                        diff = Math.Abs(total);
                    }
                    previousSum = sum;
                }
            }
            if (diff > 0)
            {
                Console.WriteLine($"No, maxdiff={diff}");
            }
            else
            {
                Console.WriteLine($"Yes, value={previousSum}");
            }
        }
    }
}
