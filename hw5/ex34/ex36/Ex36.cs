Console.WriteLine("Введите длину массива: ");
int size=Convert.ToInt32(Console.ReadLine());
int[] numbers= new int[size];

FillArrayRNDnum(numbers);
PrintArray(numbers);
int SumNumbers=0;
for(int i=0;i<numbers.Length;i+=2)
{
    SumNumbers+= numbers[i];
}
Console.Write(SumNumbers);

void FillArrayRNDnum(int[] array)
{
    for(int i=0;i<array.Length;i++)
    {
        array[i]=new Random().Next(-100,101);
    }
}

void PrintArray(int[] array)
{
    for (int i=0;i<array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}