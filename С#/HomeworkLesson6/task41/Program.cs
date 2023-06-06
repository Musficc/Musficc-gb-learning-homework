// Задача 41:
// Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int[] CreateArray()
{
    int[] Array = new int[0];
    string input;
    int convertedInput;
    System.Console.WriteLine("\nВведите число, которое хотите добавить. Если закончили, введите \"STOP\".");
    for (byte i = 0; ; i++)
    {
        System.Console.Write("> ");
        input = Console.ReadLine();
        if (input == "STOP" || input == "stop") break;
        else
        {
            convertedInput = Convert.ToInt32(input);
            System.Array.Resize(ref Array, Array.Length + 1);
            Array[i] = convertedInput;
        }
    }
    return Array;
}

void OutputArray(int[] Array)
{
    byte result = 0;
    Console.WriteLine("\nВы ввели числа:");
    for (byte i = 0; i < Array.Length; i++)
    {
        System.Console.Write($"{Array[i]} ");
        if (Array[i] > 0) result++;
    }
    System.Console.WriteLine($"\nЧисел больше нуля среди них: {result}\n");
}

int[] Array = CreateArray();
OutputArray(Array);