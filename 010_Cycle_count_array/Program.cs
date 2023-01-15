int GetNumber(string message)
{
    int number = 0;
    System.Console.Write(message);

    while (true)
    {
        if (int.TryParse(Console.ReadLine(), out number))
            break;

        System.Console.Write("Invaled input! Try again: ");
    }

    return number;
}

int Exponentiation(int number, int degree)
{
    int outValue = (int)Math.Pow(number, degree);
    return outValue;
}

bool CheckingForNegativeNumbers()
{
    System.Console.WriteLine("Do you want all numbers to be negative?");

    int theConfirmation = 0;
    bool choice = false;

    for (int i = 0; i < 5; i++)
    {
        if(i == 0)
            theConfirmation = GetNumber("Enter <1> for yes; \r\nEnter <2> for no; \r\n");
        else if(i > 0 && i < 4)
            theConfirmation = GetNumber("1 or 2 ... again: ");
        else
            System.Console.WriteLine("Learn to write! The values will be negative!");
        

        if (theConfirmation == 2)
        {
            choice = true;
            break;
        }
        else if(theConfirmation == 1)
            break;
        
    }
    return choice;
}

int SumDigitsInNumber(int number, bool choice)
{
    byte flag = 0;
    sbyte value = 0;
    int sum = 0;
    while (true)
    {
        if (!choice && number != 0)
        {
            sum += number % 10;
            number /= 10;
        }
        else if(choice && number != 0)
        {
            sum += number % 10;
            value = (sbyte)(number % 10);
            number /= 10;
            flag = 1;
        }
        else
        {
            if(flag == 1)
                sum = sum * -1 + (value + value);

            break;
        }
    }
    return sum;
}

int [] CreateArray (int value)
{
    int [] array = new int [value];
    Random random = new Random();

    for(int i = 0; i < value; i++)
    {
        array [i] = random.Next(0, 100);
    }
    return array;

}

void PrintFirstResalt (int oneValue, int twoValue, int resalt)
{
    System.Console.WriteLine($"{oneValue},{twoValue} -> {resalt}");
}

void PrintSecondResalt (int oneValue, int resalt)
{
    System.Console.WriteLine($"{oneValue} -> {resalt}");
}

void PrintArray (int [] array)
{
    System.Console.WriteLine("-> [ " + string.Join(", ", array) + " ]");
}

//==========================================> 
//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Clear();
System.Console.WriteLine("Alexey Panshin's homework!");
System.Console.WriteLine();
System.Console.WriteLine("Task 25.");
System.Console.WriteLine("Exponentiation in degree!");
System.Console.WriteLine();

int userNumber = GetNumber("Enter number: ");
int userDegree = GetNumber("Enter degree: ");
int outValue = Exponentiation(userNumber, userDegree);

System.Console.WriteLine();
PrintFirstResalt(userNumber, userDegree, outValue);
System.Console.WriteLine();
System.Console.Write("Task 25 completed! Press key: ");
Console.ReadKey();

//======================================>
// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Clear();
System.Console.WriteLine("Task 27.");
System.Console.WriteLine("The sum of the digits in a number!");
System.Console.WriteLine();

userNumber = GetNumber("Enter number: ");
bool choice = CheckingForNegativeNumbers();
outValue = SumDigitsInNumber(userNumber, choice);

System.Console.WriteLine();
PrintSecondResalt(userNumber, outValue);
System.Console.Write("Task 27 completed! Press key: ");
Console.ReadKey();

//==================================>
// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Console.Clear();
System.Console.WriteLine("Task 29.");
System.Console.WriteLine("Set and output an array!");
System.Console.WriteLine();

int size = GetNumber("Enter size array: ");
int [] array = CreateArray(size);
System.Console.WriteLine();
PrintArray(array);

System.Console.WriteLine();
System.Console.WriteLine("Task 27 completed!");