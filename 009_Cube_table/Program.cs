//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

int EnterNumber(bool a)
{
    string enterNumber = "";
    int number = -1;

    while ( a )
    {
        System.Console.Write("Enter number: ");
        enterNumber = Console.ReadLine();

        if (Int32.TryParse(enterNumber, out number) && number > 0) a = false;
        else System.Console.WriteLine("Invalid input!");

        System.Console.WriteLine("");
    }

    return number;
}

Console.Clear();
Console.ForegroundColor = ConsoleColor.DarkYellow;
System.Console.WriteLine("Alexey Pan'shin homework!");
System.Console.WriteLine("");
System.Console.WriteLine("Table of cubes of numbers!");
Console.ResetColor();
System.Console.WriteLine("");

bool check = true;
int number = 0;
byte point = 0;

number = EnterNumber(check);

for(int i = 1; i <= number; i++)
{
    if(point == 0)
        System.Console.Write("Number cubes: ");
        point = 1;

    System.Console.Write((Math.Pow(i, 3)) + "  ");
}