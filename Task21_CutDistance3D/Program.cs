/* Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53 */

double LengthSegment3D (int xa, int ya, int za, int xb, int yb, int zb)
{
    int xSquare = Math.Abs(xa - xb) * Math.Abs(xa - xb);
    int ySquare = Math.Abs(ya - yb) * Math.Abs(ya - yb);
    int zSquare = Math.Abs(za - zb) * Math.Abs(za - zb);
    return Math.Sqrt(xSquare + ySquare + zSquare);
}

Console.WriteLine("Added segment coordinate x of point A:");
int pointXA = int.Parse(Console.ReadLine()!);
Console.WriteLine("Added segment coordinate y of point A:");
int pointYA = int.Parse(Console.ReadLine()!);
Console.WriteLine("Added segment coordinate z of point A:");
int pointZA = int.Parse(Console.ReadLine()!);


Console.WriteLine("Added segment coordinate x of point B:");
int pointXB = int.Parse(Console.ReadLine()!);
Console.WriteLine("Added segment coordinate y of point B:");
int pointYB = int.Parse(Console.ReadLine()!);
Console.WriteLine("Added segment coordinate z of point B:");
int pointZB = int.Parse(Console.ReadLine()!);

Console.WriteLine(Math.Round(LengthSegment3D(pointXA, pointYA, pointZA, pointXB, pointYB, pointZB), 2));