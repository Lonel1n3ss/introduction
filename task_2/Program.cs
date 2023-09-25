// Задача №11. Работа в группах
// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

using System.ComponentModel.DataAnnotations;

int num = new Random().Next(100, 1000); 
int a1 = num / 100;
int a2 = num % 10;
System.Console.WriteLine($"Число {num} -> {a1} {a2}");

// Задача №12. Работа в группах
// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.

// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

int number1 = Convert.ToInt32(Console.ReadLine()); 
int number2 = Convert.ToInt32(Console.ReadLine()); 
int res;
if(number1 % number2 == 0){
    System.Console.WriteLine($"кратно");
}
else {
    res = number1 % number2;
    System.Console.WriteLine($"не кратно, остаток {res}");
}
