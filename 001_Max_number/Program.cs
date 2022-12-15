Console.Write("Введите первое число: ");
int oneNumber = Convert.ToInt32(System.Console.ReadLine());

Console.Write("Введите второе число: ");
int twoNumber = Convert.ToInt32(System.Console.ReadLine());

if (oneNumber > twoNumber)
    System.Console.WriteLine("Число " + oneNumber + " больше числа " + twoNumber);
else
    System.Console.WriteLine("Число " + twoNumber + " больше числа " + oneNumber);