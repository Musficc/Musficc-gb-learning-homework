// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

//получаем число от пользователя, записываем в input
System.Console.Write("\nВводи число: ");
long input = Convert.ToInt64(Console.ReadLine());

//если число отрицательное - переводим его в положительное
if(input<0)
{input = Math.Abs(input);}

//узнаём длинну числа, записываем в len
sbyte len = 0;
for(long i = input; i>0; i/=10)
{len++;}

//создаём массив inputArr переписываем в него каждую цифру числа input
long[] inputArr = new long[len];

for(long i = input; i>0; i/=10)
{
    inputArr[len-1] = i%10;
    len--;
}

//проверяем разбитое по массиву число на палиндромность и запоминаем результат
long left = 0;
long right = inputArr.Length-1;
bool isPalindrome = true;

while (left<right)
{
    if(inputArr[left] == inputArr[right])
    {
        left++;
        right--;
    }
    else
    {
        isPalindrome = false;
        break;
    }
}

//выводим результат
if (isPalindrome) {System.Console.WriteLine("Число палиндром.");}
else {System.Console.WriteLine("Число не палиндром.");}