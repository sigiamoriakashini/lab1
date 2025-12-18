using System;

class Program
{
    static void Main()
    {
        int[] array = { 1, 2, 3, 2, 1, 4, 5, 3, 6 };
        Console.Write("Массив: ");
        foreach (int num in array)
        Console.Write(num + " ");
        Console.WriteLine();
        int distinctCount = 0;
        for (int i = 0; i < array.Length; i++)
        {
            bool isNew = true;
            for (int j = 0; j < i; j++)
            {
                if (array[i] == array[j])
                {
                    isNew = false;
                    break;
                }
            }
            if (isNew)
            {
                distinctCount++;
            }
        }
        Console.WriteLine($"Количество различных элементов: {distinctCount}");
    }
}