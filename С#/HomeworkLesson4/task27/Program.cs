// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int input = 0;

int sumOfNums(int input)
{
    int a = 0;
    while (input > 0)
    {
        a += input % 10;
        input /= 10;
    }
    return a;
}

System.Console.WriteLine(sumOfNums(input));
