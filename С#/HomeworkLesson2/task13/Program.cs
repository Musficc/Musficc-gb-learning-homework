// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

System.Console.Write("\nВведите число: ");
long input = Convert.ToInt64(Console.ReadLine());

if(input<100) {System.Console.WriteLine("Третьей цифры нет.");}

else if (input<1000) {System.Console.WriteLine(input%10);}

else
{
    while (input>1000)
    {
        input /= 10;
    }
    System.Console.WriteLine(input%10);
}