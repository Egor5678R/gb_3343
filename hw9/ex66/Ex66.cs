int GetNumber(string message)
{
    Console.WriteLine(message);
    int useNum = Convert.ToInt32(Console.ReadLine());
    return useNum;
}

void PrintNum(int num, int count, int sum)
{
    if (count <= num)
    {
        sum = sum + count;
        PrintNum(num, count + 1, sum);
    }
    else Console.WriteLine(sum);
}

int m = GetNumber("Введите M:");
int n = GetNumber("Введите N:");
int summa = 0;
Console.WriteLine("|\nv");
PrintNum(n, m, summa);