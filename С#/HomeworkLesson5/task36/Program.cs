// Задача 36:
// Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

sbyte[] createArray()
{
    sbyte[] Array = new sbyte[4];
    for (byte i = 0; i < 4; i++)
    {
        Array[i] = Convert.ToSByte(new Random().Next(-128,128));
    }
    return Array;
}

short sumOfElementsInOddpos(sbyte[] Array)
{
    short result = 0;
    for (byte i = 1; i < Array.Length; i+=2)
    {
        result += Array[i];
    }
    return result;
}

void outputArray(sbyte[] Array)
{
    System.Console.Write($"Задан массив: [");
    byte i = 0;
    while (i < Array.Length-1)
    {
        System.Console.Write($"{Array[i]}, ");
        i++;
    }
    System.Console.WriteLine($"{Array[i]}]");
}

sbyte[] Array = createArray();
outputArray(Array);
System.Console.WriteLine($"Сумма чисел на нечётных позициях в массиве: {sumOfElementsInOddpos(Array)}");