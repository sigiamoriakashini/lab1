using System;

class Program
{
    static void Main()
    {
        // Ввод первого массива
        Console.Write("Введите количество элементов первого массива: ");
        int n1 = Convert.ToInt32(Console.ReadLine());
        
        int[] array1 = new int[n1];
        Console.WriteLine("Введите элементы первого массива:");
        for (int i = 0; i < n1; i++)
        {
            Console.Write($"Элемент {i + 1}: ");
            array1[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.Write("\nВведите количество элементов второго массива: ");
        int n2 = Convert.ToInt32(Console.ReadLine());
        int[] array2 = new int[n2];
        Console.WriteLine("Введите элементы второго массива:");
        for (int i = 0; i < n2; i++)
        {
            Console.Write($"Элемент {i + 1}: ");
            array2[i] = Convert.ToInt32(Console.ReadLine());
        }
        int count = 0;
        
        for (int i = 0; i < n1; i++)
        {
            bool found = false;
            for (int j = 0; j < n2; j++)
            {
                if (array1[i] == array2[j])
                {
                    found = true;
                    break;
                }
            }
            
            if (found)
            {
                count++;
            }
        }
        Console.WriteLine("\n=== РЕЗУЛЬТАТЫ ===");
        Console.Write("Первый массив: ");
        for (int i = 0; i < n1; i++)
        {
            Console.Write(array1[i] + " ");
        }
        
        Console.Write("\nВторой массив: ");
        for (int i = 0; i < n2; i++)
        {
            Console.Write(array2[i] + " ");
        }
        
        Console.WriteLine($"\n\nКоличество элементов первого массива, которые есть во втором: {count}");
    }
}