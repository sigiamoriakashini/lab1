using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите целое число: ");
        int number = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите цифру для поиска (0-9): ");
        int digitToFind = Convert.ToInt32(Console.ReadLine());
        int tempNumber = Math.Abs(number); 
        bool found = false;
        while (tempNumber > 0)
        {
            int lastDigit = tempNumber % 10;
            if (lastDigit == digitToFind)
            {
                found = true;
                break;
            }
            tempNumber /= 10;
        }
        Console.WriteLine($"Цифра {digitToFind} {(found ? "входит" : "не входит")} в запись числа {number}");
        tempNumber = Math.Abs(number);
        int reversedNumber = 0;
        while (tempNumber > 0)
        {
            int lastDigit = tempNumber % 10;
            reversedNumber = reversedNumber * 10 + lastDigit;
            tempNumber /= 10;
        }
        if (number < 0)
        {
            reversedNumber = -reversedNumber;
        }
        Console.WriteLine($"Число с цифрами в обратном порядке: {reversedNumber}");
        if (number <= 0)
        {
            Console.WriteLine($"Число {number} не является числом Фибоначчи (только положительные числа)");
        }
        else
        {
            int a = 1, b = 1; // F1 и F2
            
            while (b < number)
            {
                int next = a + b;
                a = b;
                b = next;
            }
            
            if (b == number || number == 1)
            {
                Console.WriteLine($"Число {number} является числом Фибоначчи");
            }
            else
            {
                Console.WriteLine($"Число {number} не является числом Фибоначчи");
            }
        }
    }
}