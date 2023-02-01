int GetNumber(string message)
{
    System.Console.Write(message);
    int n = Convert.ToInt32(Console.ReadLine());
    return n;
}

void PrintIntegers(int n)
{
    Console.Write(n == 1 ? (n + ";") : (n + ", ")); 
    if(n > 1) PrintIntegers(--n);
}

void SumElements(int min, int max, ref int sum)
{
    if(min <= max)
    {
        sum += min;
        SumElements(++min, max, ref sum);
    }
}

int AckermanFunction(int m, int n)
{
    if(m == 0) return n + 1;
    else if(m > 0 && n == 0) return AckermanFunction(m - 1, 1);
    else return AckermanFunction(m - 1, AckermanFunction(m, n - 1));
}
// a(0, a(1, 1)) 0, 1,0
// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
// Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Clear();
System.Console.WriteLine("Домашняя работа Паньшина Алексея.");
System.Console.WriteLine();
System.Console.WriteLine("Задача 64.");
System.Console.WriteLine("Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.");
System.Console.WriteLine();

int n = GetNumber("Введите число: ");
System.Console.Write($"n = {n} -> ");
PrintIntegers(n);
Console.ReadKey();


// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Clear();
System.Console.WriteLine();
System.Console.WriteLine("Задача 66.");
System.Console.WriteLine("Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.");
System.Console.WriteLine();

int min = GetNumber("Введите минимальное число: ");
int max = GetNumber("Введите максимальное число: ");

int rezalt = 0;
SumElements(min, max, ref rezalt);

System.Console.WriteLine();
System.Console.WriteLine($"min = {min}; max = {max}; -> {rezalt};");
Console.ReadKey();

// Задача 68: Напишите программу вычисления функции Аккермана 
// с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Clear();
System.Console.WriteLine("Задача 68.");
System.Console.WriteLine("Напишите программу вычисления функции Аккермана с помощью рекурсии.");
System.Console.WriteLine();

int m = GetNumber("Введите число M: ");
n = GetNumber("Введите число N: ");

System.Console.WriteLine();
int rezult = AckermanFunction(m, n);
System.Console.WriteLine($"m = {m}; n = {n}; A({m},{n}) = {rezult}");