// Напишите программу, которая на вход принимае число N и выдает
// таблицу кубов числе от 1 до N

void CoubOfN (int n)
{
    Console.WriteLine($"Таблица кубов от 1 до {n}:");

    int i = 0;
    while(i <= n)
    {
        double help = Math.Pow(i, 3);
        Console.Write(help + " ");
        i++;
    }

}

Console.WriteLine("Введите ваше число N?");
int n = int.Parse(Console.ReadLine());
CoubOfN(n);