Console.WriteLine("Введите длину массива: ");
int size=Convert.ToInt32(Console.ReadLine());
int[] numbers= new int[size];
int count=0;
FillArrayRNDnum(numbers);
PrintArray(numbers);

for(int i=0;i<numbers.Length;i++)
{
    if (numbers[i]%2==0)
    {
        count++;  
    }
        
    
    

}
if (count==0)
{
    Console.WriteLine("В массиве нет четных чисел");
}
        
if (count>=1)
{
    Console.WriteLine($"Четные числа массива: {count}");
}


void FillArrayRNDnum(int[] array)
{
    for(int i=0;i<array.Length;i++)
    {
        array[i]=new Random().Next(100,1000);
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