Console.WriteLine(" введите не менее восьми элементов через запятую: ");
string inputString=string.Empty;
int countElements=0;
int expectedElements=8;
while (countElements<expectedElements)
{
    Console.Write($" {inputString}");
    inputString+=Console.ReadLine();
    countElements=CountСharacter(inputString,',')+1;
    if (countElements<expectedElements)
        Console.WriteLine(" недостаточно элементов");
}
int start=0;
int end=0;
int[] resultArray=new int[expectedElements];
for (int i=0;i<resultArray.Length; i++)
{
    end=SearchСharacter(inputString, ',', start+1)-1;
    if (end<0)
        end=inputString.Length-1;
    string textNumber=SubString(inputString, start, end);
    resultArray[i]=Convert.ToInt32(textNumber);
    start=end+2;
}
Console.Write(" ");
PrintArray(resultArray, '[', ']', ", ", true);
int SearchСharacter(string sourceString, char searchСharacter, int start)
{
    for (int i=start; i<sourceString.Length; i++)
    {
        if (sourceString[i]==searchСharacter)
        {
            return i;
        }
    }
    return-1;
}
int CountСharacter(string sourceString, char searchСharacter)
{
    int count=0;
    for (int i=0; i<sourceString.Length; i++)
    {
        if (sourceString[i]==searchСharacter)
        {
            count++;
        }
    }
    return count;
}
string SubString(string sourceString, int start, int end)
{
    string result=String.Empty;
    for (int i=start; i<=end; i++)
        result+=sourceString[i];
    return result;
}
void PrintArray(int[] array, char startSymbol, char endSymbol, string separator, bool endLine)
{
    Console.Write(startSymbol);
    for (int i=0; i<array.Length; i++)
    {
        Console.Write(array[i]);
        if (i!=array.Length-1)
            Console.Write(separator);
    }
    Console.Write(endSymbol);
    if (endLine)
        Console.WriteLine();
}