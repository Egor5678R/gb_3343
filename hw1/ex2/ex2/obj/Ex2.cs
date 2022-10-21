Console.WriteLine("Введите 2 числа");
string numberAstr = Console.ReadLine() ??"";
string numberBstr = Console.ReadLine() ??"";
int numberA = int.Parse(numberAstr);
int numberB = int.Parse(numberBstr);
Console.Write($"Большее число из {number1} и {number2}, это ");
if (numberA > numberB)
{
    Console.Write(numberA);
}
else
{
    Console.Write(numberB);
}

