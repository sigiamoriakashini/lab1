
class Program
{
    static void Main()
    {
        int[] array = { 1, 3, 2, 5, 4, 6, 8, 7 };
        
        int maxLength = 1;
        int currentLength = 1;
        int endIndex = 0;
        
        for (int i = 0; i < array.Length - 1; i++)
        {
            if (array[i] < array[i + 1])
            {
                currentLength++;
                if (currentLength > maxLength)
                {
                    maxLength = currentLength;
                    endIndex = i + 1;
                }
            }
            else
            {
                currentLength = 1;
            }
        }
        
        Console.WriteLine($"Максимальная длина возрастающей подпоследовательности: {maxLength}");
        Console.Write("Подпоследовательность: ");
        
        int startIndex = endIndex - maxLength + 1;
        for (int i = startIndex; i <= endIndex; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
    }
}