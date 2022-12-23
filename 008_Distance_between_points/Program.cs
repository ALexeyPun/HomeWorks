// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53


double UserEnter(string messege)
{
    System.Console.Write(messege);

    Console.ForegroundColor = ConsoleColor.Green;
    double number = Convert.ToDouble(Console.ReadLine());
    Console.ResetColor();
    
    return number;
}

double SearchPoint(double a, double b)
{
    double exitNumber = Math.Pow((b - a), 2);
    return exitNumber;
}

double DistanceBetweenPoints(double x, double y, double z)
{
    double exitNumber = Math.Sqrt(x + y + z);
    return exitNumber;
}

//СТАРТ ПРОГРАММЫ=================================================>
//учимся работать с функциями

Console.Clear();
Console.ForegroundColor = ConsoleColor.DarkYellow;
System.Console.WriteLine("Alexey Pan'shin homework!");
System.Console.WriteLine("");
System.Console.WriteLine("Find the distance between points in 3D space!");
Console.ResetColor();
System.Console.WriteLine("");

System.Console.WriteLine("Enter point A coordinates:");
System.Console.WriteLine("");

double ax = UserEnter("Enter X coordinate - ");
double ay = UserEnter("Enter Y coordinate - ");
double az = UserEnter("Enter Z coordinate - ");

System.Console.WriteLine("");
System.Console.WriteLine("Enter point B coordinates:");
System.Console.WriteLine("");

double bx = UserEnter("Enter X coordinate - ");
double by = UserEnter("Enter Y coordinate - ");
double bz = UserEnter("Enter Z coordinate - ");

double x = SearchPoint(ax, bx);
double y = SearchPoint(ay, by);
double z = SearchPoint(az, bz);

double distance = DistanceBetweenPoints(x, y, z);

System.Console.WriteLine("");
Console.ForegroundColor = ConsoleColor.DarkGreen;
System.Console.WriteLine("Расстояние между точками в 3D пространстве - " + Math.Round(distance, 2) + ";");
Console.ResetColor();