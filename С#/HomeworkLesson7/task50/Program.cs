// Задача 50.
// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

byte firstInput = 2;
byte secondInput = 0;

byte[,] Array = new byte[,]
{
    {1, 4, 7, 2},
    {5, 9, 2, 3},
    {8, 4, 2, 4}
};

for (int i = 0; i < Array.GetLength(0); i++)
{
    for (int j = 0; j < Array.GetLength(1); j++)
    {
        System.Console.Write($"{Array[i,j]} ");
    }
    System.Console.WriteLine();
}

if (firstInput <= 2 && firstInput >= 0 && secondInput <= 3 && secondInput >= 0)
{
    System.Console.WriteLine($"В заданной позиции найден элемент: {Array[firstInput,secondInput]}");
}
else {System.Console.WriteLine("В заданной позиции нет элемента.");}