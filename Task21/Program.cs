﻿// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координаты точки A");
Console.WriteLine("x = ");
int xA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("y = ");
int yA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("z = ");
int zA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки B");
Console.WriteLine("x = ");
int xB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("y = ");
int yB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("z = ");
int zB = Convert.ToInt32(Console.ReadLine());

double distance = Distance (xA, yA, zA, xB, yB, zB);

Console.WriteLine(Math.Round(distance, 2, MidpointRounding.ToZero));

double Distance (int x1, int y1, int z1, int x2, int y2, int z2)
{
    int cat1 = x1 - x2;
    int cat2 = y2 - y1;
    int cat3 = z1 - z2;
    double hypo = Math.Sqrt(cat1 * cat1 + cat2 * cat2 + cat3 * cat3);
    return hypo;
}