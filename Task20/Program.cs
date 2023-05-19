// Задача 20: Напишите программу, которая
// принимает на вход координаты двух точек и
// находит расстояние между ними в 2D
// пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

Console.WriteLine("Введите координаты точки A");
Console.WriteLine("x = ");
int xA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("y = ");
int yA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки B");
Console.WriteLine("x = ");
int xB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("y = ");
int yB = Convert.ToInt32(Console.ReadLine());

double distance = Distance (xA, yA, xB, yB);

Console.WriteLine(Math.Round(distance, 2, MidpointRounding.ToZero));

double Distance (int x1, int y1, int x2, int y2)
{
    int cat1 = x1 - x2;
    int cat2 = y2 - y1;
    double hypo = Math.Sqrt(cat1 * cat1 + cat2 * cat2);
    return hypo;
}