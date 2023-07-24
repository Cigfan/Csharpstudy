/*int num = new Random().Next(1000);
string numstring = num.ToString();

if(numstring.Length == 3){
    Console.WriteLine($"Число {num} без второй цифры имеет вид {numstring[0]}{numstring[2]}");
}
else{
    Console.WriteLine("Число не трехзначное");
    }
*/
// Задача 1. Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
// 78 -> 8
// 12-> 2
// 85 -> 8

// int first = new Random().Next(10, 100);
// string numstring = first.ToString();
// if(numstring[0] > numstring[1]){
//     Console.WriteLine($"{numstring[0]} больше чем {numstring[1]} в числе {first}");
// }
// else{
//     Console.WriteLine($"{numstring[1]} больше чем {numstring[0]} в числе {first}");
// }

/*Задача 2. Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. 
Если второе число не кратно числу первому, то программа выводит остаток от деления.

34, 5 -> не кратно, остаток 4
16, 4  -> кратно*/

/*Console.Write("Введите первое число: ");
int second1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе число: ");
int second2 = int.Parse(Console.ReadLine()!);
if(second1 % second2 == 0){
    Console.WriteLine("Да, кратно первому числу.");
}
else{
    Console.WriteLine($"Нет, не кратно, остаток от деления - {second1 % second2}");
}*/

/*Задача 3. Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
14  ->  нет
46  ->  нет
161 ->  да*/

// Console.Write("Введите первое число: ");
// int Alpha = int.Parse(Console.ReadLine()!);
// if(Alpha % 7 == 0 && Alpha % 23 == 0){
//     Console.WriteLine("Да");
// }
// else{
//     Console.WriteLine("нет");
// }

/*Задача 4. Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.*/

Console.Write("Введите первое число: ");
int hitotsu = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе число: ");
int futatsu = int.Parse(Console.ReadLine()!);
if(hitotsu * hitotsu == futatsu){
    Console.WriteLine($"Число {futatsu} является квадратом числа {hitotsu}");
}
else if(futatsu * futatsu == hitotsu){
    Console.WriteLine($"Число {hitotsu} является квадратом числа {futatsu}");
}
else{Console.WriteLine($"ниодно из чисел {hitotsu} и {futatsu} не является квадратом другого.");}

