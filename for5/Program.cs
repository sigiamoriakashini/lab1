using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите число x: ");
        double x = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите степень n (натуральное число): ");
        int n = Convert.ToInt32(Console.ReadLine());    
        double result = 1;
        for (int i = 1; i <= n; i++)
        {
            result = result * x;
        }
        Console.WriteLine($"{x} в степени {n} = {result}");
    }
}