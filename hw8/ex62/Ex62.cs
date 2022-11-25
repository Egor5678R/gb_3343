int m = GetNumber("Введите размерность матрицы: ");

int k = 1;
int bias = 0;

int GetNumber(string message)
{
    Console.Write(message);
    int useNum = Convert.ToInt32(Console.ReadLine()); ;
    return useNum;
}

int[,] InitArray(int m)
{
    int[,] tempArray = new int[m, m];
       while ((m / 2) - bias >= 0)
    {
        for (int i = (0 + bias); i < tempArray.GetLength(1) - bias; i++)
        {
            tempArray[bias, i] = k;
            k++;
        }
        for (int i = (0 + bias) + 1; i < tempArray.GetLength(0) - bias; i++)
        {
            tempArray[i, tempArray.GetLength(1) - bias - 1] = k;
            k++;
        }
        for (int i = tempArray.GetLength(1) - bias-2; i > bias-1; i--)
        {
            tempArray[tempArray.GetLength(0) - bias -1, i] = k;
            k++;
        }
        for (int i = tempArray.GetLength(1) - bias-2; i > bias; i--)
        {
            tempArray[i, tempArray.GetLength(0) - (tempArray.GetLength(0)-bias)] = k;
            k++;
        }
        bias++;
    }

    return tempArray;
}

void PrintArray(int[,] tempArray)
{
    string form = string.Empty;
    string k = (tempArray.GetLength(0) * tempArray.GetLength(1)).ToString();
    for (int i = 0; i < k.Length; i++)
    {
        form = form + "0";
    }
    for (int i = 0; i < tempArray.GetLength(0); i++)
    {
        for (int j = 0; j < tempArray.GetLength(1); j++)
        {
            Console.Write($"{tempArray[i, j].ToString(form)} ");
        }
        Console.WriteLine();
    }
}

int[,] array = InitArray(m);
PrintArray(array);