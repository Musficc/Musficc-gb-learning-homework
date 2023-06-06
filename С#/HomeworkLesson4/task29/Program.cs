// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

// Функция создания массива. Создаёт заполняемый пользователем массив и возвращает его.
// Условия задачи и примеры расходятся, так что пользователь сам определяет длинну массива.
long[] createArray()
{
    System.Console.Write("\nСколько элементов будет в массиве?\n> ");
    byte inputLength = Convert.ToByte(Console.ReadLine());

    long[] Array = new long[inputLength];

    for (int i = 0; i < Array.Length; i++)
    {
        System.Console.Write($"Введите элемент массива №{i+1}\n> ");
        Array[i] = Convert.ToInt64(Console.ReadLine());
    }
    return Array;
}

// Функция красивого вывода массива на экран. В качестве аргумента принимает массив long
void outputArray(long[] Array)
{
    System.Console.Write($"Массив: [");
    int i = 0;
    while (i < Array.Length-1)
    {
        System.Console.Write($"{Array[i]}, ");
        i++;
    }
    System.Console.WriteLine($"{Array[i]}]");
}

// Используем функции и получаем результат.
long[] Array = createArray();
outputArray(Array);