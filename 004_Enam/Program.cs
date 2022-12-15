System.Console.WriteLine("Enter number: ");
int userNumber = Convert.ToInt32(Console.ReadLine());

if (userNumber < 2) System.Console.WriteLine("Your number does not match the format.");
if (1 == userNumber % 2) userNumber--;

for (int i = 2; i <= userNumber; i += 2)
{
    Console.WriteLine(i);
}