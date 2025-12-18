using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите номер числа Фибоначчи (n > 0): ");
        int n = Convert.ToInt32(Console.ReadLine());        
        if (n <= 0)
        {
            Console.WriteLine("Номер должен быть положительным числом!");
            return;
        }        
        long fib1 = 1; 
        long fib2 = 1; 
        long fibN = 1; 
        if (n == 1 || n == 2)
        {
            fibN = 1;
        }
        else
        {
            for (int i = 3; i <= n; i++)
            {
                fibN = fib1 + fib2;
                fib1 = fib2;
                fib2 = fibN;
            }
        }
        Console.WriteLine($"{n}-е число Фибоначчи: {fibN}");
    }
}