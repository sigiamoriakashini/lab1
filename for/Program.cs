using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите натуральное число n: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int sum = 0;
        for (int i = 1; i <= n; i++)
        {
            sum = sum + i * (i + 1);
        }
        
        Console.WriteLine($"Сумма ряда для n = {n}: {sum}");
    }
}