// Задача 58:
// Задайте две матрицы.
// Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] Mat1 = new int[,]
{
    {2, 4},
    {3, 2}
};

int[,] Mat2 = new int[,]
{
    {3, 4},
    {3, 3}
};

int[,] MatResult = new int[Mat1.GetLength(0), Mat1.GetLength(1)];

void WriteArray(int[,] Array)
{
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        System.Console.WriteLine();
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            System.Console.Write($"{Array[i, j]} ");
        }
    }
}

int[,] TwoMatMul(int[,] Mat1, int[,] Mat2)
{
    if (Mat1.GetLength(1) != Mat2.GetLength(0))
    {
        System.Console.WriteLine("Число столбцов матрицы 1 не совпадает с числом строк матрицы 2.");
        return Mat1;
    }

    int[,] MatResult = new int[Mat1.GetLength(0), Mat2.GetLength(1)];
    int summ = 0;

    for (int Res0 = 0; Res0 < MatResult.GetLength(0); Res0++)
    {
        for (int Res1 = 0; Res1 < MatResult.GetLength(1); Res1++)
        {
            for (int j = 0; j < MatResult.GetLength(1); j++)
            {
                summ = Mat1[Res0,j]*Mat2[j,Res1];
                MatResult[Res0,Res1] += summ;
            }
        }
    }

    return MatResult;
}

System.Console.Write("\nМатрица 1:");
WriteArray(Mat1);
System.Console.Write("\nи матрица 2:");
WriteArray(Mat2);

System.Console.WriteLine("\nИх произведение:");
int[,] Result = TwoMatMul(Mat1,Mat2);
WriteArray(Result);