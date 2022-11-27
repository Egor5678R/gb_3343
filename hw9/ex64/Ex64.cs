int GetNumber(string message)
{
     Console.Write(message);
     int useNum = Convert.ToInt32(Console.ReadLine());;
     return useNum;
}

string bust(int num)
{
    string str = string.Empty;
    if (num == 1) return num.ToString();
    return num + " " + bust(num - 1);
}

int m = GetNumber("Введите m: ");
Console.WriteLine("|\nv");
Console.WriteLine(bust(m));