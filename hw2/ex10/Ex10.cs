

int number = ReadInt("Введите трехзначное число: ");
int digit = number.ToString().Length;
if (digit < 3 || digit > 3)
{
    Console.WriteLine("Вы ввели не трехзначное число");
}
else
{
    Console.WriteLine(InCenter(number));
}
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int InCenter(int i)
{
    int result = ((i / 10) % 10);
    return result;
}
