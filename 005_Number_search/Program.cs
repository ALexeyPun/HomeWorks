Console.Clear();

void End(bool meaning, int numb, int pos)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($"In the entered number - {numb}, with position - {pos}, no number!");
    Console.ResetColor();
    Environment.Exit(0);
}

int RequestedNumber(int number, int index)
{
    int outNum = 0;
    int divider = 0;

    if (index == 1) divider = 10;
    if (index == 2) divider = 100;
    if (index == 3) divider = 1000;

    for (int i = divider; number > i;) number /= 10;
    outNum = number % 10;
    return outNum;
}

System.Console.Write("Enter number: ");
Console.ForegroundColor = ConsoleColor.Blue;
int enterNumber = Convert.ToInt32(Console.ReadLine());
Console.ResetColor();
enterNumber = Math.Abs(enterNumber);

System.Console.Write("What number do you want to output? Enter position 1 - 3: ");
Console.ForegroundColor = ConsoleColor.Blue;
int position = Convert.ToInt32(Console.ReadLine());
Console.ResetColor();

if (position > 0 && position < 4)
{
    if (enterNumber < 100 && position == 3) End(true, enterNumber, position);
    if (enterNumber < 10 && position > 1) End(true, enterNumber, position);

    int outputNumber = RequestedNumber(enterNumber, position);
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"In the entered number - {enterNumber}, with position - {position}, there is the number - {outputNumber}");
    Console.ResetColor();
}
else 
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Your position does not match the format!");
    Console.ResetColor();
}