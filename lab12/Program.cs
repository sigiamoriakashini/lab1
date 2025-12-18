// Программа 1 тут надо было вывести True если хотя бы одно число из тёрх чётное
/* 
class Program {
    static void Main() {
        Console.WriteLine("Введите 3 числа");
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());
        int c = Convert.ToInt32(Console.ReadLine());
        bool result = ((a % 2 ==0 ? 1 : 0) + (b % 2 == 0 ? 1 : 0) + (b % 2 == 0 ? 1 : 0)) == 1; 
        Console.WriteLine(result);  
        }
}
*/
// Программа 2 где нужно реализовать было сравнение чисел и вывод максимального
/*
class Program {
    static void Main() {
        Console.WriteLine("Введите 3 числа");
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());
        int c = Convert.ToInt32(Console.ReadLine()); 
        int result = (a > b) ? (a > c ? a : c) : (b > c ? b : c );
        Console.WriteLine(result);
    }

}
*/

// Программа 3 надо вывести числа в порядке возрастания

/*
class Program
    {
    static void Main() {
        Console.WriteLine("Введите три целых числа:");
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());
        int c = Convert.ToInt32(Console.ReadLine()); 
        int min, mid, max; 
        if (a <= b && a <= c)
        {
            min = a;       
            if (b <= c)
            {
                mid = b;
                max = c;
            }
                else
            {
                mid = c;
                max = b;
            }
        }
        else if (b <= a && b <= c)
        {
            min = b;
            if (a <= c)
            {
                mid = a;
                max = c;
            }
            else
            {
                mid = c;
                max = a;
            }
        }
        else
        {
                min = c;
            if (a <= b)
            {
                mid = a;
                max = b;
            }
            else
            {
                mid = b;
                max = a;
            }
        }
        Console.Write (min);
        Console.Write (mid);
        Console.Write (max);
    }
}
*/

// программа 4 бьёт ли конь или не бьёт 
/*
class Program   {
    static void Main() {
        Console.WriteLine("Введите координаты коня (x1, y1):");
        int x1 = Convert.ToInt32(Console.ReadLine());
        int y1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите координаты фигуры противника (x2, y2):");
        int x2 = Convert.ToInt32(Console.ReadLine());
        int y2 = Convert.ToInt32(Console.ReadLine());
        int dx = Math.Abs(x2 - x1);
        int dy = Math.Abs(y2 - y1);
        if ((dx == 2 && dy == 1) || (dx == 1 && dy == 2)) {
            Console.WriteLine("Конь бьёт фигуру противника!");
            }
        else {
            Console.WriteLine("Конь не бьёт фигуру противника.");
            }
        }
    }
*/
// Программа 5 тут даётся 3 числа которые означают дату и надо проверить её корректность
/*
class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите день (1-31):");
            int day = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите месяц (1-12):");
            int month = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите год (1800-9999):");
            int year = Convert.ToInt32(Console.ReadLine());
            int[] daysInMonth = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            bool isValid = true;
            if (year < 1800 || year > 9999 || month < 1 || month > 12 || day < 1)
            {
                isValid = false;
            }
            else
            {
                int maxDays = daysInMonth[month - 1];
                if (month == 2 && (year % 4 == 0 && year % 100 != 0 || year % 400 == 0))
                {
                    maxDays = 29; 
                }
                if (day > maxDays)
                {
                    isValid = false;
                }
            }
            Console.WriteLine(isValid ? $"Дата {day}/{month}/{year} корректна." : $"Дата {day}/{month}/{year} некорректна.");
        }
    }
*/

// Программа 6 что бы вычислять дату следующего дня 
/*
class Program
{
    static void Main()
    {
        Console.Write("Введите день: ");
        int day = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите месяц: ");
        int month = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите год: ");
        int year = Convert.ToInt32(Console.ReadLine());
        bool isLeapYear = false;
        if (year % 400 == 0)
        {
            isLeapYear = true;
        }
        else if (year % 100 == 0)
        {
            isLeapYear = false;
        }
        else if (year % 4 == 0)
        {
            isLeapYear = true;
        }
        int daysInMonth = 0;
        if (month == 1) daysInMonth = 31;
        else if (month == 2)
        {
            if (isLeapYear)
                daysInMonth = 29;
            else
                daysInMonth = 28;
        }
        else if (month == 3) daysInMonth = 31;
        else if (month == 4) daysInMonth = 30;
        else if (month == 5) daysInMonth = 31;
        else if (month == 6) daysInMonth = 30;
        else if (month == 7) daysInMonth = 31;
        else if (month == 8) daysInMonth = 31;
        else if (month == 9) daysInMonth = 30;
        else if (month == 10) daysInMonth = 31;
        else if (month == 11) daysInMonth = 30;
        else if (month == 12) daysInMonth = 31;
        if (day < daysInMonth)
        {
            day++;
        }
        else
        {
            day = 1;
            if (month < 12)
            {
                month++;
            }
            else
            {
                month = 1;
                year++;
            }
        }
        Console.WriteLine($"Дата следующего дня: {day}.{month}.{year}");
    }
}
*/

// программа 7 тут надо вывести цифру с правильным падедём слово рубль
/*
 class Program
{
    static void Main()
    {
        Console.Write("Введите число от 1 до 999: ");
        int number = Convert.ToInt32(Console.ReadLine());
        
        string rubleWord = "";
        
        // Получаем две последние цифры для исключений (11-14)
        int lastTwoDigits = number % 100;
        
        // Получаем последнюю цифру
        int lastDigit = number % 10;
        
        // Проверяем исключения 11-14
        if (lastTwoDigits >= 11 && lastTwoDigits <= 14)
        {
            rubleWord = "рублей";
        }
        else
        {
            // Для остальных случаев проверяем последнюю цифру
            if (lastDigit == 1)
            {
                rubleWord = "рубль";
            }
            else if (lastDigit >= 2 && lastDigit <= 4)
            {
                rubleWord = "рубля";
            }
            else
            {
                rubleWord = "рублей";
            }
        }
        
        Console.WriteLine($"{number} {rubleWord}");
    }
}
*/