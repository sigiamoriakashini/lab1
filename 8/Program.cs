using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите количество спортсменов: ");
        int n = Convert.ToInt32(Console.ReadLine());
        double[] results = new double[n];
        Console.WriteLine("Введите результаты спортсменов на 100 м (в секундах):");
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Спортсмен {i + 1}: ");
            results[i] = Convert.ToDouble(Console.ReadLine());
        }
        Console.WriteLine("\nВсе результаты:");
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Спортсмен {i + 1}: {results[i]} сек");
        }
        if (n < 4)
        {
            Console.WriteLine($"\nНедостаточно спортсменов! Нужно минимум 4, а есть только {n}");
            return;
        }
        double[] sortedResults = new double[n];
        Array.Copy(results, sortedResults, n);
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = i + 1; j < n; j++)
            {
                if (sortedResults[j] < sortedResults[i])
                {
                    double temp = sortedResults[i];
                    sortedResults[i] = sortedResults[j];
                    sortedResults[j] = temp;
                }
            }
        }
        Console.WriteLine("\nРезультаты по возрастанию (лучшие сначала):");
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"{i + 1}-е место: {sortedResults[i]} сек");
        }
        Console.WriteLine("\n=== КОМАНДА ИЗ 4 ЛУЧШИХ СПОРТСМЕНОВ ===");
        int[] teamIndices = new int[4];
        int teamCount = 0;
        for (int i = 0; i < 4; i++)
        {
            double bestResult = sortedResults[i];
            for (int j = 0; j < n; j++)
            {
                if (results[j] == bestResult)
                {
                    bool alreadyAdded = false;
                    for (int k = 0; k < teamCount; k++)
                    {
                        if (teamIndices[k] == j)
                        {
                            alreadyAdded = true;
                            break;
                        }
                    }
                    
                    if (!alreadyAdded)
                    {
                        teamIndices[teamCount] = j;
                        teamCount++;
                        break;
                    }
                }
            }
        }
        for (int i = 0; i < 4; i++)
        {
            int index = teamIndices[i];
            Console.WriteLine($"Спортсмен {index + 1}: {results[index]} сек");
        }
    }
}