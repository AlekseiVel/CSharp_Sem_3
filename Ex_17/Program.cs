// Напишите прошрамму, которая принимает на вход координаты точки (X, Y), 
// причем и X и Y не равно 0, и выдает номер четверти плоскости,
// в которой находится эта точка



//getNumberOfQuater
int GetNQ(double X, double Y)
{
    int nq = -1;

    if(X>0 && Y>0)
    {
        nq = 1; 
    }
    if(X<0 && Y>0)
    {
        nq = 2;
    }     
    if(X<0 && Y<0)
    {
        nq = 3; 
    }
    if(X>0 && Y<0)
    {
        nq = 4;
    }

return nq;      
}
Console.WriteLine("Введите координату по Х");
double X = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координату по Y");
double Y = double.Parse(Console.ReadLine()!);

int nq = GetNQ(X, Y);
if (nq == -1)
    Console.WriteLine("Неверный формат координат!");
else
    Console.WriteLine($"Номер четверти: {nq}");