// Задача 47.
// Задайте двумерный массив размером m×n,
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

decimal[,] CreateArray(byte m, byte n)
{
    decimal[,] Array = new decimal[m, n];
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            Array[i, j] = Convert.ToDecimal(new Random().NextDouble());
            Array[i, j] += new Random().NextInt64();
        }
    }
    return Array;
}

void OutputArray(decimal[,] Array)
{
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        System.Console.WriteLine();
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            System.Console.WriteLine($"{Array[i, j]} ");
        }
    }
}

byte m = 3;
byte n = 4;

OutputArray(CreateArray(m,n));