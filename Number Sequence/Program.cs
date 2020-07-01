using System;

namespace Number_Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int maxNum = int.MinValue;
            int minNum = int.MaxValue;

            for (int i = 0; i < number; i++)
            {
                int n = int.Parse(Console.ReadLine());
                if (n < minNum)
                {
                    minNum = n;
                }
                else if (n > maxNum)
                {
                    maxNum = n;
                }
            }
            Console.WriteLine($"Max number: {maxNum}");
            Console.WriteLine($"Min number: {minNum}");
        }
    }
}
