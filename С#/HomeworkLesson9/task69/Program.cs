// Задача 68:
// Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int m = 2, n = 3;

int A(int input1, int input2)
{
    if (input1 == 0) { return input2 + 1; }
    if ((input1 > 0) && (input2 == 0)) { return A(input1 - 1, 1); }
    if ((input1 > 0) && (input2 > 0)) { return A(input1 - 1, A(input1, input2 - 1)); }
    else return 0;
}

System.Console.WriteLine(A(m, n));