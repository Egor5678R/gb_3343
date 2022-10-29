int number = ReadInt(" введите число: ");
int len = NumberLen(number);
SumNumbers(number, len);
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
int NumberLen(int a)
{
    int index = 0;
    while (a > 0)
    {
        a /= 10;
        index++;
    }
    return index;
}
void SumNumbers(int num, int len)
{
    int sum = 0;
    for (int i = 1; i <= len; i++)
    {
        sum += num % 10;
        num /= 10;
    }
    Console.WriteLine(sum);
}