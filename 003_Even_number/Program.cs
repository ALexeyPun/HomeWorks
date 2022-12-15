System.Console.WriteLine("Enter number: ");
int number = Convert.ToInt32(Console.ReadLine());

int remainder = number % 2;

if(remainder == 0)System.Console.WriteLine( number + " - is an even number.");
else System.Console.WriteLine( number + " - is not an even number.");