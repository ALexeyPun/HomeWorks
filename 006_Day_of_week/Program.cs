Console.Write("Enter day of week: ");

int day = 0;

while(true)
{
    day = Convert.ToInt32(Console.ReadLine());

    if(day > 0 && day < 8) break;

    Console.Write("Your number does not match the format! Enter again: ");
}

if(day == 6 || day == 7) Console.WriteLine("Day " + day + " - it's day off!");
else Console.WriteLine("Day " + day + " - it's working day!");