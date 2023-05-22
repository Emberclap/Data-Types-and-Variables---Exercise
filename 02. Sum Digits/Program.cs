﻿namespace _02._Sum_Digits
{
    internal class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            int sumOfDigits = 0;
            while (number > 0)
            {
                int lastDigit = number % 10;
                sumOfDigits += lastDigit;
                number /= 10;

            }
            Console.WriteLine(sumOfDigits);
        }
    }
}