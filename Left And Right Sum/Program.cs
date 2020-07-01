using System;

namespace Left_And_Right_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int rightSum = 0;
            int leftSum = 0;


            for (int i = 0; i < number; i++)
            {
                int leftNum = int.Parse(Console.ReadLine());
                leftSum += leftNum;
            }

            for (int i = 0; i < number; i++)
            {
                int rightNum = int.Parse(Console.ReadLine());
                rightSum += rightNum;
            }
            if (rightSum == leftSum)
            {
                Console.WriteLine($"Yes, sum = {rightSum}");
            }
            else
            {
                int diff = Math.Abs(leftSum - rightSum);
                Console.WriteLine($"No, diff = {diff}");
            }
        }
    }
}
