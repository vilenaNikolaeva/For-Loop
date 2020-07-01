using System;

namespace Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            double p1count = 0;
            double p2count = 0;
            double p3count = 0;
            double p4count = 0;
            double p5count = 0;
            double total = 0;


            for (int i = 0; i < number; i++)
            {
                int n = int.Parse(Console.ReadLine());
                if (n < 200)
                {
                    total += n;
                    p1count++;
                }
                else if (n >= 200 && n <= 399)
                {
                    total += n;
                    p2count++;
                }
                else if (n >= 400 && n <= 599)
                {
                    total += n;
                    p3count++;
                }
                else if (n >= 600 && n <= 799)
                {
                    total += n;
                    p4count++;
                }
                else if (n >= 800)
                {
                    total += n;
                    p5count++;
                }
            }
            Console.WriteLine($"{(p1count / number) * 100:f2}%");
            Console.WriteLine($"{(p2count / number) * 100:f2}%");
            Console.WriteLine($"{p3count / number * 100:f2}%");
            Console.WriteLine($"{p4count / number * 100:f2}%");
            Console.WriteLine($"{p5count / number * 100:f2}%");
        }
    }
}
