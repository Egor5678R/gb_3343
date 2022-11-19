Console.WriteLine("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] arr = new int[m, n];
int count=0;
double sum = 0;

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

for (int j = 0; j < arr.GetLength(1); j++)
{
    count++;

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        sum += arr[i, j];
        
    }
    Console.WriteLine("|\nv");
    Console.Write($"Среднее арифметическое с {count} строки - { sum / arr.GetLength(0)} \n");
}
