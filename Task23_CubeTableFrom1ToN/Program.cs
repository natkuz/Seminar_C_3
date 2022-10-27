/* Задача 23. Напишите программу, которая принимает на вход число (N) 
и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125 */

void PrintCubeTableFrom1ToN(int n)
{
    if (n >= 1)
    {
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine(i * i * i);
        }
    }
    else
    {
        Console.WriteLine("Введено неверное значение");
    }
}

Console.WriteLine("Введите положительное число:");
int number = int.Parse(Console.ReadLine()!);
Console.WriteLine();
PrintCubeTableFrom1ToN(number);
