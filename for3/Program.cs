using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите начало диапазона (a): ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите конец диапазона (b): ");
        int b = Convert.ToInt32(Console.ReadLine());       
        Console.WriteLine($"Числа Армстронга в диапазоне [{a}, {b}]:");
        for (int number = a; number <= b; number++)
        {
            int sum = 0;
            int temp = number;
            int digitsCount = 0;
            int tempCount = number;
            while (tempCount > 0)
            {
                digitsCount++;
                tempCount /= 10;
            }
            temp = number;
            while (temp > 0)
            {
                int digit = temp % 10;
                int power = 1;
                for (int i = 0; i < digitsCount; i++)
                {
                    power = power * digit;
                }
                sum = sum + power;
                temp /= 10;
            }
            if (sum == number)
            {
                Console.WriteLine(number);
            }
        }
    }
}