Console.WriteLine("Введите два числа: ");
string numberAstr = Console.ReadLine() ??"";
string numberBstr = Console.ReadLine() ??"";
int numberA = int.Parse(numberAstr);
int numberB = int.Parse(numberBstr);
Console.Write($"Большее из чисел {numberA} и {numberB}, это число ");
if (numberA > numberB)
{
    Console.Write(numberA);
}
else
{
    Console.Write(numberB);
}