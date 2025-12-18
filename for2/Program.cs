using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите натуральное число n: ");
        int n = Convert.ToInt32(Console.ReadLine());
        long product = 1; 
        for (int i = 2; i <= n; i += 2)
        {
            product = product * i;
        }
        Console.WriteLine($"Произведение для n = {n}: {product}");
    }
}