int x1 = ReadInt(" введите координату x 1 точки: ");
int y1 = ReadInt(" введите координату y 1 точки: ");
int z1 = ReadInt(" введите координату z 1 точки: ");
int x2 = ReadInt(" введите координату x 2 точки: ");
int y2 = ReadInt(" введите координату y 2 точки: ");
int z2 = ReadInt(" введите координату z 2 точки: ");

int x = x2 - x1;
int y = y2 - y1;
int z = z1 - z2;

double length = Math.Sqrt(x * x + y * y + z * z);
Console.WriteLine($"A({x1},{y1},{z1}); B({x2},{y2},{z2}) -> {length}");
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}