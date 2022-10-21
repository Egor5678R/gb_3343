Console.WriteLine("Введите три числа: ");
string numberstr = Console.ReadLine() ??"";



int number = int.Parse(numberstr);


if (number % 2 == 0)
{
    Console.Write($"Число {number} делится нацело, т.е чётное");
}

{
    Console.Write($"Число {number} неделится нацело, т.е. нечётное");
}

