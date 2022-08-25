// Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 2D пространстве

double GetRange(double x1, double y1, double x2, double y2)
{
    
    double dx = Math.Abs(x1 - x2);
    
    double dy = Math.Abs(y1 - y2);
    
    double range = Math.Sqrt(dx*dx + dy*dy);
    
return range;

}  

Console.WriteLine("Введите координату по Х первой точки");
double x1 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координату по Y первой точки");
double y1 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координату по Х второй точки");
double x2 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координату по Y второй точки");
double y2 = double.Parse(Console.ReadLine()!);

double range = GetRange(x1, y1, x2, y2);
    
Console.WriteLine($"Расстояние между точками {range:f2}");