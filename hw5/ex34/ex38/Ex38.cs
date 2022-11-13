Console.WriteLine("Введите длину массива: ");
int size=Convert.ToInt32(Console.ReadLine());
int[] numbers= new int[size];

FillArrayRNDnum(numbers);
PrintArray(numbers);
int min=Int32.MaxValue;
int max=Int32.MinValue;

for(int i=0;i<numbers.Length;i++)
{
    if (numbers[i]>max)
    {
        max=numbers[i];
    }
        
    if (numbers[i]<min)
    {
        min=numbers[i];
    }
}
Console.WriteLine($" Максимум: {max} \n Минимум: {min} \n Разница между максимумом и минимумом: {max-min}");

void FillArrayRNDnum(int[] array)
{
    for(int i=0;i<array.Length;i++)
    {
        array[i]=new Random().Next(1,1000);
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