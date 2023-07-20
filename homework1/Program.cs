﻿/*Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3*/

Console.Write("Введите первое число: ");
int first = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе число: ");
int second = int.Parse(Console.ReadLine()!);
if(first > second){
    Console.WriteLine($"{first} больше {second}");
}
else Console.WriteLine($"{second} больше {first}");

/*Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22*/

Console.Write("Введите первое число: ");
int first = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе число: ");
int second = int.Parse(Console.ReadLine()!);
Console.Write("Введите третье число: ");
int third = int.Parse(Console.ReadLine()!);
int answer = 0;
if(first > answer){
    answer = first;
    }
if(second > answer){
    answer = second;
    }
if(third > answer){
    answer = third;
    }
Console.WriteLine($"Из чисел {first},{second} и {third}, наибольшее - {answer}");

/*Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет*/

Console.Write("Введите Ваше число: ");
int what = int.Parse(Console.ReadLine()!);
if(what % 2 == 0){
    Console.WriteLine($"Число {what} - четное");
}
else Console.WriteLine($"Число {what} - не четное");

/*Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8*/

Console.Write("Введите Ваше число: ");
int omega = int.Parse(Console.ReadLine()!);
int alpha = 1;
while(alpha <= omega){
    if(alpha % 2 == 0){
        Console.Write(alpha);
        }
        alpha ++;
    }