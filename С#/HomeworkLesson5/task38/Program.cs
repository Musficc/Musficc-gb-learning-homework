// Задача 38:
// Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

decimal[] createArray()
{
    decimal[] Array = new decimal[4];
    for (byte i = 0; i < 4; i++)
    {
        Array[i] = Convert.ToDecimal(new Random().NextDouble());
        Array[i] += new Random().Next(0,100);
    }
    return Array;
}

void outputArray(decimal[] Array)
{
    System.Console.Write($"\nЗадан массив: [");
    byte i = 0;
    while (i < Array.Length-1)
    {
        System.Console.Write($"{Array[i]}, ");
        i++;
    }
    System.Console.WriteLine($"{Array[i]}]\n");
}

decimal difOfNums(decimal[] Array)
{
    decimal min=Array[0];
    decimal max=Array[0];

    for (int i = 0; i < Array.Length; i++)
    {
        if (Array[i] > max) max = Array[i];
        if (Array[i] < min) min = Array[i];
    }
    decimal result = max-min;
    return result;
}

decimal[] Array = createArray();
outputArray(Array);
System.Console.WriteLine($"Разница между максимальным и минимальным элементами массива: {difOfNums(Array)}");