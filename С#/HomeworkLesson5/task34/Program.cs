// Задача 34:
// Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

ushort[] createArray()
{
    ushort[] Array = new ushort[4];
    for (int i = 0; i < 4; i++)
    {
        Array[i] = Convert.ToUInt16(new Random().Next(100,1000));
    }
    return Array;
}

byte evenNumbersOfArray(ushort[] Array)
{
    byte result = 0;
    for (int i = 0; i < Array.Length; i++)
    {
        if (Array[i] % 2 == 0) result ++;
    }
    return result;
}

void outputArray(ushort[] Array)
{
    System.Console.Write($"Задан массив: [");
    int i = 0;
    while (i < Array.Length-1)
    {
        System.Console.Write($"{Array[i]}, ");
        i++;
    }
    System.Console.WriteLine($"{Array[i]}]");
}

ushort[] Array = createArray();
outputArray(Array);
System.Console.WriteLine($"Чётных чисел в массиве: {evenNumbersOfArray(Array)}");