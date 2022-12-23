// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

int[] AssignmentToArray(int number, int size)
{
    int temporaryNumber = 0;
    int[] array = new int[size--];

    for (int i = 0; i <= size; i++)
    {
        temporaryNumber = number % 10;
        number /= 10;
        array[size - i] = temporaryNumber;
    }
    return array;
}

bool Examination(int[] array, int size)
{
    bool check = true;
    for (int i = 0; i < size / 2; i++)
    {
        if (array[i] != array[size - 1 - i])
        {
            check = false;
            break;
        }
    }
    return check;
}

Console.Clear();
System.Console.WriteLine("Alexey Panshin's homework!");
System.Console.WriteLine("");

System.Console.Write("Enter number: ");
string userEnter = Console.ReadLine();

int size = (userEnter.Length);
int palindrome = Convert.ToInt32(userEnter);

int[] array = new int[size];

array = AssignmentToArray(palindrome, size);
bool check = Examination(array, size);

if(check) Console.WriteLine("The Number is a palindrome!");
else Console.WriteLine("Number is not a palindrome!");