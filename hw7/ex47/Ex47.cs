Console.WriteLine("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());
double[,] arr = new double[m, n];

Random rnd = new Random();
void PrintArray(double[,] matrnd)
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

void FillArray(double[,] matrnd)
{ 
    for (int i = 0; i < m; i++)
    { 

    for (int j = 0; j < n; j++)
    { 
    matrnd[i,j] = Convert.ToDouble(rnd.Next(-100, 100)/10.0);
    }

    }

}
FillArray(arr);
Console.WriteLine("|\nV");
PrintArray(arr);