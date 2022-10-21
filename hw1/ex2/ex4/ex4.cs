Console.WriteLine("Введите три числа");
string numberAstr = Console.ReadLine() ??"";
string numberBstr = Console.ReadLine() ??"";
string numberCstr = Console.ReadLine() ??"";


int numberA = int.Parse(numberAstr);
int numberB = int.Parse(numberBstr);
int numberC = int.Parse(numberCstr);
int max = numberA;

if (numberB > max)
{
    max = numberB;
}
if (numberC > max)
{
    max = numberC;
}
Console.WriteLine($"Самое большое число {max}");