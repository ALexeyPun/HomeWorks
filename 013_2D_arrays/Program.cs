int GetNumber(string message)
{
    int number = 0;
    Console.Write(message);

    while (true)
    {
        if (int.TryParse(Console.ReadLine(), out number))
            break;

        Console.Write("Не понял, ещё раз: ");
    }
    return number;
}

int[,] CreateAndFillArray(int rows, int columns)
{
    int[,] array = new int[rows, columns];

    Random r = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = r.Next(1, 10);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void IndexCheck(int[,] array)
{
    int rowsIndex = 0;
    int columnsIndex = 0;


    rowsIndex = GetNumber("Введите ряд: ");
    columnsIndex = GetNumber("Введите колонну: ");

    if ((rowsIndex >= 0 && rowsIndex < array.GetLength(0)) && (columnsIndex >= 0 && columnsIndex < array.GetLength(1)))
        Console.WriteLine($"Указанное значение -> {array[rowsIndex, columnsIndex]} ;");
    else
        Console.WriteLine("Вы ввели не корректные данные!");

    Console.WriteLine();
}

void AverageColumns(int[,] array, int rows, int columns)
{
    double average = 0;

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            average += (double)(array[i, j]);
        }
        Console.WriteLine($"Среднее арифметическое {i} колонки = {average / (columns - 1)}");
    }
}


// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.Clear();
Console.WriteLine("Alexey Pah'shin homework.");
Console.WriteLine();
Console.WriteLine("Task 47");
Console.WriteLine("Задайте двумерный массив размером m x n, заполненный случайными вещественными числами.");
Console.WriteLine();

int rows = GetNumber("Введите колличество линий: ");
int columns = GetNumber("Ведите колличество колонок: ");
int[,] array = CreateAndFillArray(rows, columns);

Console.WriteLine();
PrintArray(array);
Console.WriteLine();
Console.ReadKey();



// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.Clear();
Console.WriteLine("Task 50");
Console.WriteLine("Проверка позиции элемента.");
Console.WriteLine();

PrintArray(array);
Console.WriteLine();

string userChoice = string.Empty;
do
{
    IndexCheck(array);
    Console.WriteLine("Ещё разок?");
    Console.Write("Введите > YES < для повтора: ");

} while (Console.ReadLine().ToLower() == "yes");

Console.WriteLine();


// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Clear();
Console.Clear();
Console.WriteLine("Task 52");
Console.WriteLine("Найдите среднее арифметическое элементов в каждом столбце.");
Console.WriteLine();

PrintArray(array);
Console.WriteLine();

AverageColumns(array, rows, columns);
Console.WriteLine();
Console.ReadKey();