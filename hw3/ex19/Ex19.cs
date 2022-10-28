Console.WriteLine(" введите число: ");
string number = Console.ReadLine();
int len = number.Length;
if (len == 5)
{
    if (number[0] == number[4] && number[1] == number[3])
    {
        Console.WriteLine($" палидром? {number} - да");
    }
    else
    {
        Console.WriteLine($" палидром? {number} - нет");
    }
}
else
{
    Console.WriteLine($" {number} - не пятизначное число");
}