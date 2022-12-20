/*Задача 10: Напишите программу, которая принимает  
на вход трёхзначное число и на выходе показывает вторую цифру этого числа. 
Выполнить с помощью числовых операций (целочисленное деление, остаток от деления). 

456 -> 5
782 -> 8
918 -> 1  */

Console.Write("Введите трех значное число: ");
int number = Convert.ToInt32(Console.ReadLine());

// int res1 = number / 10;
// int res = res1 % 10;
// Console.WriteLine($"Вторая цифра числа {number} => {res}");

int SecondDigit(int num)
{
    int res1 = num / 10;
    int res = res1 % 10;
    return res;
}

int second = SecondDigit(number);
Console.WriteLine($"Вторая цифра числа {number} => {second}");


// int second1 = SecondDigit(785);
// Console.WriteLine(second1);