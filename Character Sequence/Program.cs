using System;

namespace Character_Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();


            for (int i = 0; i <= name.Length - 1; i++)
            {
                char symbol = name[i];
                Console.WriteLine(symbol);
            }
        }
    }
}
