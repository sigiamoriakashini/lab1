using System;

class Program
{
    static void Main()
    {
        // Пример массива
        int[] array = { 10, 22, 9, 33, 21, 50, 41, 60, 80 };
        Console.Write("Исходный массив: ");
        foreach (int num in array)
            Console.Write(num + " ");
        Console.WriteLine();
        int n = array.Length;
        int[] dp = new int[n];
        for (int i = 0; i < n; i++)
        {
            dp[i] = 1;
        }
        for (int i = 1; i < n; i++)
        {
            for (int j = 0; j < i; j++)
            {
                if (array[i] > array[j] && dp[i] < dp[j] + 1)
                {
                    dp[i] = dp[j] + 1;
                }
            }
        }
        int maxLength = 0;
        int maxIndex = 0;
        for (int i = 0; i < n; i++)
        {
            if (dp[i] > maxLength)
            {
                maxLength = dp[i];
                maxIndex = i;
            }
        }        
        Console.WriteLine($"Максимальная длина возрастающей подпоследовательности: {maxLength}");       
        int[] subsequence = new int[maxLength];
        int currentLength = maxLength;
        int currentIndex = maxIndex;  
        subsequence[currentLength - 1] = array[currentIndex];
        currentLength--;
        for (int i = maxIndex - 1; i >= 0; i--)
        {
            if (dp[i] == currentLength && array[i] < array[currentIndex])
            {
                subsequence[currentLength - 1] = array[i];
                currentLength--;
                currentIndex = i;
            }
        }
        Console.Write("Возрастающая подпоследовательность максимальной длины: ");
        for (int i = 0; i < maxLength; i++)
        {
            Console.Write(subsequence[i] + " ");
        }
        Console.WriteLine();
    }
}