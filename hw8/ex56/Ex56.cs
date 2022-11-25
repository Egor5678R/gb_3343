Console.WriteLine("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] arr = new int[m, n];
int tempNumbers=0;



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
    matrnd[i,j] = Convert.ToInt32(rnd.Next(1,10));
    }

    }

}
FillArray(arr);
Console.WriteLine("|\nv");
PrintArray(arr);

int[] GetArrayRowsSum(int[,] tempArray)
{
    int[] arrayRows = new int[tempArray.GetLength(1)];
    for (int i = 0; i < tempArray.GetLength(0); i++)
    {
        for (int j = 0; j < tempArray.GetLength(1); j++)
        {
            arrayRows[j] = arrayRows[j] + tempArray[i, j];
        }
    }
    return arrayRows;
}

int GetMinimalArrayRowsSum(int[] sum)
{
    int minimalSum = sum[0];
    int minimalSumIndex = 1;
    for (int i = 1; i < sum.Length; i++)
    {
        if (minimalSum < sum[i]) minimalSumIndex = i + 1;
    }
    return minimalSumIndex;
}

int[] sum = GetArrayRowsSum(arr);
Console.WriteLine("|\nv");
Console.WriteLine($"Минимальная сумма строки {GetMinimalArrayRowsSum(sum)}");

