// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int input1 = 3;
int input2 = 5;

double idkHowToName(int num, int secNum)
{
    double result = Math.Pow(num, secNum);
    return result;
}

System.Console.WriteLine(idkHowToName(input1,input2));