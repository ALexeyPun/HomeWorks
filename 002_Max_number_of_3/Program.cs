Console.Write("Enter number one: ");
int oneNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter number two: ");
int twoNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter number three: ");
int threeNumber = Convert.ToInt32(Console.ReadLine());

int max = oneNumber;

if (max < twoNumber) max = twoNumber;
if (max < threeNumber) max = threeNumber;

Console.WriteLine("Max number = " + max);