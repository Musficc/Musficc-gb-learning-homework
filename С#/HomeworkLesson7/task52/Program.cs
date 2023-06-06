// Задача 52.
// Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

byte[,] Array = new byte[,]
{
    {1, 4, 7, 2},
    {5, 9, 2, 3},
    {8, 4, 2, 4}
};

void GetArithmeticMeanOfArrayColumns(byte[,] Array)
{
    float Results = 0;
    System.Console.WriteLine();
    for (int i = 0; i < Array.GetLength(1); i++)
    {
        Results = 0;
        for (int j = 0; j < Array.GetLength(0); j++)
        {
            Results += Array[j, i];
        }
        Results /= Array.GetLength(0);
        System.Console.WriteLine($"{Results} ");
    }
    System.Console.WriteLine();
}

GetArithmeticMeanOfArrayColumns(Array);