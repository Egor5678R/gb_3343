int number = ReadInt(" введите число N: ");
for (int a = 1; a <= number; a++)
{ 
    Console.Write($"{a*a*a} ");
}
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
