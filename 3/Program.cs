using System;

class Program
{
    static void Main()
    {
        int[] array = { 1, 2, 3, 2, 1, 5, 6, 7, 6, 5 };
        
        int maxLength = 1;
        int startIndex = 0;
        
        // Проверяем все возможные подпоследовательности
        for (int i = 0; i < array.Length; i++)
        {
            for (int j = i; j < array.Length; j++)
            {
                // Проверяем, симметрична ли подпоследовательность от i до j
                bool isSymmetric = true;
                int length = j - i + 1;
                
                for (int k = 0; k < length / 2; k++)
                {
                    if (array[i + k] != array[j - k])
                    {
                        isSymmetric = false;
                        break;
                    }
                }
                
                // Если симметрична и длина больше максимальной
                if (isSymmetric && length > maxLength)
                {
                    maxLength = length;
                    startIndex = i;
                }
            }
        }
        
        Console.WriteLine($"Максимальная длина симметричной подпоследовательности: {maxLength}");
        Console.Write("Подпоследовательность: ");
        
        for (int i = startIndex; i < startIndex + maxLength; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
    }
}