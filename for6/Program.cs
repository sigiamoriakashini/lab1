using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Счастливые номера билетов (6-значные числа):");
        for (int number = 100000; number <= 999999; number++)
        {
            int digit1 = number / 100000;        
            int digit2 = (number / 10000) % 10;  
            int digit3 = (number / 1000) % 10;   
            int digit4 = (number / 100) % 10;       
            int digit5 = (number / 10) % 10;    
            int digit6 = number % 10;            
            int sumFirstThree = digit1 + digit2 + digit3;
            int sumLastThree = digit4 + digit5 + digit6;
            if (sumFirstThree == sumLastThree)
            {
                Console.WriteLine(number);
            }
        }
    }
}