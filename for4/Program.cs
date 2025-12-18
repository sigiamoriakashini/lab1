using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите начало диапазона (a): ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите конец диапазона (b): ");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Пары дружественных чисел в диапазоне [{a}, {b}]:");
        for (int i = a; i <= b; i++)
        {
            // Находим сумму делителей первого числа (не включая само число)
            int sum1 = 0;
            for (int divisor = 1; divisor <= i / 2; divisor++)
            {
                if (i % divisor == 0)
                {
                    sum1 = sum1 + divisor;
                }
            }
            if (sum1 > i && sum1 >= a && sum1 <= b)
            {
                int sum2 = 0;
                for (int divisor = 1; divisor <= sum1 / 2; divisor++)
                {
                    if (sum1 % divisor == 0)
                    {
                        sum2 = sum2 + divisor;
                    }
                }
                if (sum2 == i)
                {
                    Console.WriteLine($"{i} и {sum1}");
                }
            }
        }
    }
}