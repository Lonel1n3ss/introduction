// Задача 10: Напишите программу, которая принимает на вход трезначное число и на выходе показывает вторую цифру этого числа. 
using System.Reflection.Metadata.Ecma335;

System.Console.WriteLine("Введите трехзначное число: ");
int a = Convert.ToInt32(Console.ReadLine());
a /= 10;
int b = a % 10;
System.Console.WriteLine($"Вторая цифра -> {b}");

//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. 
System.Console.WriteLine("Введите трехзначное число: ");
int c = Convert.ToInt32(Console.ReadLine());
int d;

if (c > 100)
{
    d = c % 10;
    System.Console.WriteLine($"Третья цифра -> {d} ");
}
else
{
    System.Console.WriteLine("Третьей цифры нет");
}

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
System.Console.WriteLine("Введите номер дня недели: ");
int day = Convert.ToInt32(Console.ReadLine());


if (day < 0 && day > 7)
{
    System.Console.WriteLine("В неделе всего 7 дней");
}
else if(day>5 && day<=7)
{
    System.Console.WriteLine("Выходной день!");
}
else {
    System.Console.WriteLine("Будний день!");
}
