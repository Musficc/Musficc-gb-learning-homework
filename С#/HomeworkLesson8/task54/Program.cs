// Задача 54:Задайте двумерный массив.
// Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

// задаю любой массив с типом элементов byte
byte[,] Array = new byte[,]
{
    {1, 4, 7, 2},
    {5, 9, 2, 3},
    {8, 4, 2, 4}
};

// функция вывода массива в консоль
void ConsoleWriteArray(byte[,] Array)
{
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        System.Console.WriteLine();
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            System.Console.Write($"{Array[i, j]} ");
        }
    }
    System.Console.WriteLine();
}

// функция сортировки массива
byte[,] SortArray(byte[,] Array)
{
    byte maximum;
    byte maximumPos;
    byte temp;
    // перебирем строки
    for (byte i = 0; i < Array.GetLength(0); i++)
    {
        // перебирем столбцы
        for (byte j = 0; j < Array.GetLength(1); j++)
        {
            // ищем максимальное в строчке
            maximum = Array[i, j];
            maximumPos = j;
            for (byte k = j; k < Array.GetLength(1); k++)
            {
                if (Array[i, k] > maximum)
                {
                    maximum = Array[i, k];
                    maximumPos = k;
                }
            }
            // меняем найденное максимальное местами с элементом j
            temp = Array[i, j];
            Array[i, j] = maximum;
            Array[i, maximumPos] = temp;
        }
    }
    return Array;
}

ConsoleWriteArray(Array);
SortArray(Array);
ConsoleWriteArray(Array);