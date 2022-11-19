Console.WriteLine("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] arr = new int[m, n];

Random rnd = new Random();
void PrintArray(int[,] matrnd)
{ 
    for (int i = 0; i < m; i++)
    { 

    for (int j = 0; j < n; j++)
    { 
    Console.Write($"{matrnd[i, j]} ");
    }
 Console.WriteLine();
    }

 }

void FillArray(int[,] matrnd)
{ 
    for (int i = 0; i < m; i++)
    { 

    for (int j = 0; j < n; j++)
    { 
    matrnd[i,j] = Convert.ToInt32(rnd.Next(10,90)/10);
    }

    }

}
FillArray(arr);
Console.WriteLine("|\nv");
PrintArray(arr);
Console.WriteLine("|\nv");
Console.WriteLine("Введите координаты точки a");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки b");
int b = Convert.ToInt32(Console.ReadLine());
if (a>m && b>n)
Console.WriteLine("такого числа нет");
else
{
object c=arr.GetValue(a,b);
Console.WriteLine("|\nv");
Console.WriteLine($"Эти координаты обозначают число - {c}");
}