﻿// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите x первой точки");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите y первой точки");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите z первой точки");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите x второй точки");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите y второй точки");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите z первой точки");
int z2 = Convert.ToInt32(Console.ReadLine());

double CubeX = Math.Pow(x1 - x2, 2);
double CubeY = Math.Pow(y1 - y2, 2);
double CubeZ = Math.Pow(z1 - z2, 2);
double result = Math.Sqrt(CubeX + CubeY + CubeZ);
Console.WriteLine (result);
