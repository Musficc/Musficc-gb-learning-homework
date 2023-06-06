// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22
//
Console.Write("Введите первое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int thirdNumber = Convert.ToInt32(Console.ReadLine());
//
if(firstNumber>secondNumber)
{
    if(firstNumber>thirdNumber)
    {Console.Write($"Число {firstNumber} наибольшее из предоставленых.");}
    else
    {Console.Write($"Число {thirdNumber} наибольшее из предоставленых.");}
}
else if(secondNumber>thirdNumber)
{Console.Write($"Число {secondNumber} наибольшее из предоставленых.");}
else
{Console.Write($"Число {thirdNumber} наибольшее из предоставленых.");}