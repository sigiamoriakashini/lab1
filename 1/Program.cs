using System;
class Program
{
    static void Main()
    {
        int[] array = { 1, 3, 5, 7, 9 }; 
        bool isIncreasing = true;
        for (int i = 0; i < array.Length - 1; i++)
        {
            if (array[i] >= array[i + 1])
            {
                isIncreasing = false;
                break;
            }
        }
        if (isIncreasing)
            Console.WriteLine("Массив является возрастающей последовательностью");
        else
            Console.WriteLine("Массив НЕ является возрастающей последовательностью");
    }
}