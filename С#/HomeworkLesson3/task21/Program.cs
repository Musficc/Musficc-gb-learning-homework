﻿// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

double 
A1 = 7,
A2 = -5,
A3 = 0,

B1 = 1,
B2 = -1,
B3 = 9,

result = Math.Sqrt(Math.Pow(B1-A1, 2) + Math.Pow(B2-A2, 2) + Math.Pow(B3-A3, 2));

System.Console.WriteLine(result);