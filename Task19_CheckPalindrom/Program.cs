/* Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да */

void PrintCheckPalindrom(string number)
{
    if (number.Length == 5)
    {
        if (number[0] == number[4])
        {
            if (number[1] == number[3])
            {
                Console.WriteLine("Да, значение является палиндромом");
            }
            else
            {
                Console.WriteLine("Нет, значение не является палиндромом");
            }
        }
        else
        {
            Console.WriteLine("Нет, значение не является палиндромом");
        }
    }
    else
    {
        Console.WriteLine("Введено неверное значение");
    }
}

Console.WriteLine("Введите 5-значное число:");
PrintCheckPalindrom(Console.ReadLine()!);