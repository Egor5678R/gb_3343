int dayNumber = ReadInt("dведите число дня недели: ");
Console.WriteLine(HolidayWK(dayNumber));
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
string HolidayWK(int i)
{
    if (i > 0 && i < 8)
    {
        if (i == 7 || i == 6)
        {
            Console.Write($"{i} выходной");
        }
        else
        {
            Console.Write($"{i} рабочий");
        }
    }
    else
    {
        Console.Write("вы ввели число не то число дня недели");
    }
    return " ";
}
