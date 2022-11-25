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

int[,] sortArray(int[,] tempArray)
{
    for (int i = 0; i < tempArray.GetLength(0); i++)
    {
        for (int j = 0; j < tempArray.GetLength(1); j++)
        {
            for (int k = 0; k < tempArray.GetLength(1) - 1; k++)
            {
                if (tempArray[i, k] < tempArray[i, k + 1])
                {
                    int tempNumbers = tempArray[i, k + 1];
                    tempArray [i, k + 1] = tempArray[i, k];
                    tempArray[i, k] = tempNumbers;
                }
            }
        }
    }
    return tempArray;
}

FillArray(arr);
Console.WriteLine("|\nv");
PrintArray(arr);
Console.WriteLine("|\nv");
int[,] resultArray=sortArray(arr);
PrintArray(resultArray);

