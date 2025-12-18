using System;

class Program
{
    static void Main()
    {
        int[] array = { 1, 2, 3, 4, 1, 2, 5, 6, 3, 7 };
        
        Console.Write("Массив: ");
        foreach (int num in array)
            Console.Write(num + " ");
        Console.WriteLine();
        int uniqueCount = 0;
        for (int i = 0; i < array.Length; i++)
        {
            bool isUnique = true;
            for (int j = 0; j < array.Length; j++)
            {
                if (i != j && array[i] == array[j])
                {
                    isUnique = false;
                    break;
                }
            }
            
            if (isUnique)
            {
                uniqueCount++;
            }
        }
        
        Console.WriteLine($"Количество элементов, встречающихся только один раз: {uniqueCount}");
    }
}