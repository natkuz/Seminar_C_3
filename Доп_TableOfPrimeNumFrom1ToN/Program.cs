/* Дополнительно. Напишите программу, которая принимает на вход число (N) 
и выдает таблицу простых чисел от 1 до N.
11 -> 2, 3, 5 , 7, 11 */

void PrintTableOfPrimeNumbersFrom1ToN(int n)
{
    if (n >= 1)
    {
        Console.WriteLine(1);

        if (n >= 2)
        {
            Console.WriteLine(2);
        
            for (int i = 3; i <= n; i++)
            {
                for (int k = i - 1; k >= 2; k--)
                {
                    int j = k;
                    if (i % k == 0)
                    {
                        break;
                    } 
                    if (i % k != 0 && j >= 2)
                    {
                        if (i % k != 0 && j == 2)
                        {
                            Console.WriteLine(i);
                        }
                        j--;
                    }
                }
            }
        }    
    }  
    else
    {
        Console.WriteLine("Введено неверное значение");
    }  
}

Console.WriteLine("Введите целое положительное число:");
int number = int.Parse(Console.ReadLine()!);
Console.WriteLine();
PrintTableOfPrimeNumbersFrom1ToN(number);