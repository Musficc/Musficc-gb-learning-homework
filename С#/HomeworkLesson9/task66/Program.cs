// Задача 66: 
// Задайте значения M и N.
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int M = 4, N = 8;

int Summ(int input1, int input2)
{
    if (input1 > input2) return 0;
    else return input2 + Summ(input1, input2 - 1);
}

System.Console.WriteLine(Summ(M, N));