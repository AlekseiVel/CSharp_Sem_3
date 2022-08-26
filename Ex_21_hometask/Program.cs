// Напишите программу, которая принимает на вход координаты двух точек и
// находит расстояние между ними в 3D пространстве

double GetRange(double x1, double y1, double z1, double x2, double y2, double z2)
{
    
    double dx = Math.Abs(x1 - x2);
    
    double dy = Math.Abs(y1 - y2);

    double dz = Math.Abs(z1 - z2);
    
    double range = Math.Sqrt(dx*dx + dy*dy + dz*dz);
    
return range;

}  

Console.WriteLine("Введите координату по Х первой точки");
double x1 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координату по Y первой точки");
double y1 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координату по Z первой точки");
double z1 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координату по Х второй точки");
double x2 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координату по Y второй точки");
double y2 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координату по Z второй точки");
double z2 = double.Parse(Console.ReadLine()!);

double range = GetRange(x1, y1, z1, x2, y2, z2);
    
Console.WriteLine($"Расстояние между точками {range:f2}");