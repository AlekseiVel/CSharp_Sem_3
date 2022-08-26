// Напишите программу, которая на вход принимает пятизначное число
// и проверяет, является ли оно палиндромом

int[] array = new int[5] {1, 2, 3, 4, 5};
// index                  0  1  2  3  4

Console.WriteLine("Введите первую цифру вашего числа: ");
array[0] = int.Parse(Console.ReadLine());
Console.WriteLine("Введите вторую цифру вашего числа: ");
array[1] = int.Parse(Console.ReadLine());
Console.WriteLine("Введите третью цифру вашего числа: ");
array[2] = int.Parse(Console.ReadLine());
Console.WriteLine("Введите четвертую цифру вашего числа: ");
array[3] = int.Parse(Console.ReadLine());
Console.WriteLine("Введите пятую цифру вашего числа: ");
array[4] = int.Parse(Console.ReadLine());

Console.WriteLine("Проверяемое число: ");

 for (int k = 0; k < 5; k++)
            {
                Console.Write(array[k] + " ");
            }

if(array[0]==array[4] && array[1]==array[3])
{
    Console.WriteLine("это число является палиндромом!");
}
else
{
    Console.WriteLine("это число не является палиндромом!");    
}
