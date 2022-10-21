Console.WriteLine("Введите какое нибудь число: ");
string numberAstr = Console.ReadLine() ??"";
int N = int.Parse(numberAstr);
Console.WriteLine("Четные числа от 1 до " + N);
int i = 1;
bool no = true;

while (i <= N)
{
    if (i % 2 != 1)
    {
        Console.Write(i +" ");
        no = false;
    }
    i=i+1;
}
if (no)
    {
        Console.WriteLine("Чётных чисел нет");
    }