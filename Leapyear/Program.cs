int year;
Console.WriteLine("Year :");

while (true)
if (int.TryParse(Console.ReadLine(), out year) && year > 0)
{
    bool isleapyear = (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
    if (isleapyear)
    {
        Console.WriteLine(year + " is a leap year\nSearch more years : ");
    }
    else Console.WriteLine(year + " is not a leap year\nSearch more years : ");
}
else
{
    Console.WriteLine(" \nEnter year as a positive integer !\nYear :");
}

