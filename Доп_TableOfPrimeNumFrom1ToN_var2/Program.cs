/* Дополнительно. Напишите программу, которая принимает на вход число (N) 
и выдает таблицу простых чисел от 1 до N.
11 -> 2, 3, 5 , 7, 11 */

bool isPrimeFrom1ToN(int n)
{
    if (n <= 1)
    {
        return false;
    }
    for (int i = 2; i < n; i++)
        {
            if (n % i == 0)
            {
                return false;
            } 
        }
    return true;
}

Console.WriteLine("Введите целое положительное число:");
int number = int.Parse(Console.ReadLine()!);
Console.WriteLine();
for (int i = 0; i < number; i++)
{
    if(isPrimeFrom1ToN(i))
    {
        Console.WriteLine(i + "");
    }
}