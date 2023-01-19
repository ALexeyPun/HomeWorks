int[] GetNumbersForArray(string message)
{
    System.Console.WriteLine(message);
    System.Console.WriteLine();
    System.Console.WriteLine("Для окончания ввода введите - OK !");
    System.Console.WriteLine();

    int[] userNumber = new int[50];
    int count = 0;
    string str = string.Empty;
    byte end = 0;

    for (int i = 0; i < userNumber.Length; i++)
    {
        if(i == userNumber.Length - 1)
            System.Console.WriteLine("Последний элемент!");

        while (true)
        {
            System.Console.Write($"Введите {i} значние: ");
            str = Console.ReadLine();

            if (int.TryParse(str, out userNumber[i]))
            {
                count++;
                break;
            }
            else if(str.ToLower() == "ok")
            {
                end = 1;
                break;
            }
            Console.ForegroundColor = ConsoleColor.Red;
            System.Console.WriteLine("Ещё раз!");
            Console.ResetColor();

        }

        if(end == 1)
            break;
    }

    Array.Resize(ref userNumber, count);
    return userNumber;
}

int CountNumbers(int[] array)
{
    int count = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
            count++;
    }
    return count;
}

void Print(int[] array, int count)
{
    Console.WriteLine($"[{string.Join(", ", array)}] Выше нуля -> {count}");
}



// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

//=============================>

Console.Clear();
System.Console.WriteLine("Alexey Panshin's homework!");
System.Console.WriteLine();
System.Console.WriteLine("Task 41.");
System.Console.WriteLine("Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.");

int [] array = GetNumbersForArray("Введите значения массива: ");
int count = CountNumbers(array);

System.Console.WriteLine();
Print(array, count);

System.Console.WriteLine();
Console.ForegroundColor = ConsoleColor.Green;
System.Console.WriteLine("Программа завершена!");
Console.ResetColor();