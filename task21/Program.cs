// Принимает на вход координаты двух точек 
// Находит расстояние между ними в 3Д

double FindDistance(int xA, int yA, int zA, int xB, int yB, int zB)
{
    return Math.Sqrt(Math.Pow(xB - xA, 2) + Math.Pow(yB - yA, 2) + Math.Pow(zB - zA, 2) );
}

Console.WriteLine("Введите координаты первой точки");
Console.Write("X: ");
int xCoordinateA = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int yCoordinateA = Convert.ToInt32(Console.ReadLine());
Console.Write("Z: ");
int zCoordinateA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты второй точки");
Console.Write("X: ");
int xCoordinateB = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int yCoordinateB = Convert.ToInt32(Console.ReadLine());
Console.Write("Z: ");
int zCoordinateB = Convert.ToInt32(Console.ReadLine());


double result = FindDistance(xCoordinateA, yCoordinateA, zCoordinateA, xCoordinateB, yCoordinateB, zCoordinateB);
Console.WriteLine($"{result:F2}");

