double Gipotenuza (int xA, int yA, int xB, int yB)
{
    return Math.Sqrt(Math.Pow(xB - xA, 2) + Math.Pow(yB - yA, 2));
}
Console.WriteLine("Введите координаты первой точки");
Console.WriteLine("x: ");
int xCoordinateA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("y: ");
int yCoordinateA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты второй точки");
Console.WriteLine("x: ");
int xCoordinateB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("y: ");
int yCoordinateB = Convert.ToInt32(Console.ReadLine());

double result = Gipotenuza(xCoordinateA, yCoordinateA, xCoordinateB, yCoordinateB);
Console.WriteLine($"Длина отрезка: {Math.Round(result, 2, MidpointRounding.ToZero)}");
