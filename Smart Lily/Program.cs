using System;

namespace Smart_Lily
{
    class Program
    {
        static void Main(string[] args)
        {
            int ages = int.Parse(Console.ReadLine());
            double washPrice = double.Parse(Console.ReadLine());
            int toyPrice = int.Parse(Console.ReadLine());
            int birthdayMoney = 0;
            double sum = 0;
            int count = 0;
            int totalToyPrice = 0;
            int totalBirthdayMoney = 0;

            for (int i = 1; i <= ages; i++)
            {
                if (i % 2 == 0)
                {
                    birthdayMoney += 10;
                    totalBirthdayMoney += birthdayMoney;
                    count++;
                }
                else if (i % 2 == 1)
                {
                    totalToyPrice += toyPrice;
                }
            }
            sum = (totalBirthdayMoney + totalToyPrice) - count;
            if (sum > washPrice)
            {
                Console.WriteLine($"Yes! {sum - washPrice:f2}");
            }
            else
            {
                double diff = Math.Abs(washPrice - sum);
                Console.WriteLine($"No! {diff:f2}");
            }
        }
    }
}
