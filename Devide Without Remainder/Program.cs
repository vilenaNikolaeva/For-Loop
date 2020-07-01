using System;

namespace Devide_Without_Remainder
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            double p1count = 0;
            double p2count = 0;
            double p3count = 0;



            for (int i = 0; i < number; i++)
            {
                int n = int.Parse(Console.ReadLine());
                if (n % 2 == 0)
                {
                    p1count++;
                }
                if (n % 3 == 0)
                {
                    p2count++;
                }
                if (n % 4 == 0)
                {
                    p3count++;
                }
            }
            Console.WriteLine($"{(p1count / number) * 100:f2}%");
            Console.WriteLine($"{(p2count / number) * 100:f2}%");
            Console.WriteLine($"{p3count / number * 100:f2}%");
        }
    }
}
