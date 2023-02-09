// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53


Console.WriteLine("Введите точку а: ");
int x = Convert.ToInt32(Console.ReadLine());
int y = Convert.ToInt32(Console.ReadLine());
int r = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите точку b: ");
int x1 = Convert.ToInt32(Console.ReadLine());
int y1 = Convert.ToInt32(Console.ReadLine());
int r1 = Convert.ToInt32(Console.ReadLine());

double S = Math.Sqrt(Math.Pow((x1 - x), 2)) + Math.Sqrt(Math.Pow((y1 - y), 2)) + Math.Sqrt(Math.Pow((r1 - r), 2));
 
Console.WriteLine(Math.Round(S, 2));