// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// y = k1 * x + b1, y = k2 * x + b2
// k1 * x + b1 = k2 * x + b2
// (k1 - k2) * x = b2 - b1
// x = (b2 - b1) / (k1 - k2)
// y = k1 * x + b1

// x=(b2-b1)/(k1-k2);
// y=k2 * x + b1

double GetNumber(string message)
{
    double number = 0;
    System.Console.Write(message);

    while (true)
    {
        if (double.TryParse(Console.ReadLine(), out number))
            break;

        System.Console.Write("Не понял, ещё раз: ");
    }
    return number;
}

double Find_X(double b1, double k1, double b2, double k2)
{
    double x = (b2 - b1) / (k1 - k2);
    return x;
}

double Find_Y(double x, double b2, double k2)
{
    double y = k2 * x + b2;
    return y;
}

void Print(double x, double y)
{
    System.Console.WriteLine($"Точка пересечения: x = {x}; y = {y}.");
}


double b1 = GetNumber("Введите точку B1: ");
double k1 = GetNumber("Введите точку K1: ");
double b2 = GetNumber("Введите точку B2: ");
double k2 = GetNumber("Введите точку K2: ");

if (b1 == b2 && k1 == k2)
{
    System.Console.WriteLine();
    System.Console.WriteLine("Прямые совпадают!");
}
else if (k1 == k2)
{
    System.Console.WriteLine();
    System.Console.WriteLine("Прямые параллельны!");
}
else
{
    double x = Find_X(b1, k1, b2, k2);
    double y = Find_Y(x, b2, k2);

    System.Console.WriteLine();

    Print(x, y);
}
System.Console.WriteLine();
System.Console.WriteLine("Программа завершена!");