using System;

class Program
{
    static void Main()
    {
        int[] array = { 1, 2, 3, 4, 2, 2, 3, 5, 1, 2, 3, 2 };
        Console.Write("Массив: ");
        foreach (int num in array)
            Console.Write(num + " ");
        Console.WriteLine();
        int maxElement = array[0];
        int maxCount = 0;
        for (int i = 0; i < array.Length; i++)
        {
            int currentCount = 0;
            for (int j = 0; j < array.Length; j++)
            {
                if (array[j] == array[i])
                {
                    currentCount++;
                }
            }
            if (currentCount > maxCount)
            {
                maxCount = currentCount;
                maxElement = array[i];
            }
        }
        Console.WriteLine($"Элемент {maxElement} встречается максимальное число раз: {maxCount}");
    }
}