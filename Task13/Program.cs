/* Задача 13: Напишите программу, 
которая выводит третью цифру заданного числа или сообщает, 
что третьей цифры нет. Выполнить с помощью числовых операций 
(целочисленное деление, остаток от деления).

645 -> 5
78 -> третьей цифры нет
32679 -> 6 */

Console.WriteLine("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());

// ThirdDigit(number);

// int ThirdDigit(int num)
// {
//    while (number > 999)
//    {
//       number = number /10;
//    }
//    if (number > 99 && number < 1000) Console.WriteLine($"Третья цифра числа => {number % 10}");
//    else  Console.WriteLine("Третьей цифры числа нет");  

// }

while (number > 999)
{
   number = number /10;
}
if (number > 99 && number < 1000) Console.WriteLine($"Третья цифра числа => {number % 10}");
else  Console.WriteLine("Третьей цифры числа нет");  

   
