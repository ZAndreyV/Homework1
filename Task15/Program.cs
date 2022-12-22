/* Задача 15: Напишите программу, которая принимает на вход цифру,
обозначающую день недели, и проверяет, является ли этот день выходным. 
6 -> да
7 -> да
1 -> нет */

Console.WriteLine("Ведите цифру обозначающую день недели: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Weekend(number) ? "Да" : "Нет" );

bool Weekend(int num)
{
    return num == 6 || num == 7;
}

// if (number == 6 || number == 7) Console.WriteLine("День является выходным => Да");
// else  Console.WriteLine("День является выходным => Нет");
