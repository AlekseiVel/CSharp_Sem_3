// Напишите программу, которая по заданному номеру четверти,
// показывает диапазон возможныъ координато точек в этой четверти (x и y)


void PrintCoord (int nq)
{
    if(nq == 1)
    {
        Console.WriteLine("Возможные коррдинаты в данной четверти, по X(0;+бесконечности)");
        Console.WriteLine("Возможные коррдинаты в данной четверти, по Y(0;+бесконечности)");
    }
    if(nq == 2)
    {
        Console.WriteLine("Возможные коррдинаты в данной четверти, по X(-бесконечности;0)");
        Console.WriteLine("Возможные коррдинаты в данной четверти, по Y(0;+бесконечности)");
    }
    if(nq == 3)
    {
        Console.WriteLine("Возможные коррдинаты в данной четверти, по X(-бесконечности;0)");
        Console.WriteLine("Возможные коррдинаты в данной четверти, по Y(-бесконечности;0)");
    }
    if(nq == 4)
    {
        Console.WriteLine("Возможные коррдинаты в данной четверти, по X(0;+бесконечности)");
        Console.WriteLine("Возможные коррдинаты в данной четверти, по Y(-бесконечности;0)");
    }
}

Console.WriteLine("Введите номер четверти (1-4)");
int nq = int.Parse(Console.ReadLine()!);

PrintCoord(nq);
