int number = ReadInt(" введите число: ");
int numberStep = ReadInt(" введите введите степень числа: ");
ToDegree(number, numberStep);
void ToDegree(int a, int b)
{
    int result = 1;
    for (int i = 1; i <= b; i++)
    {
        result = result * a;
    }
    Console.WriteLine(result);
}
int ReadInt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}