﻿// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

System.Console.Write("1 - Понедельник\n2 - Вторник\n3 - Среда\n4 - Четверг\n5 - Пятница\n6 - Суббота\n7- Воскресенье\n\nВведите номер дня недели: ");
byte input = Convert.ToByte(Console.ReadLine());
if ((input == 6)||(input == 7)){System.Console.WriteLine("\nДело сделано.\n");}
else {System.Console.WriteLine("\nОпять работа?\n");}