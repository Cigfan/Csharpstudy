//Console.Write("Введите число: ");
// int designation = int.Parse(Console.ReadLine()!);

//Math
/*int square = designation * designation;
Console.WriteLine($"Ваш квадрат: {square}");*/

//Lib
//int square2 = Convert.ToInt32(Math.Pow(designation, 2));
//Console.WriteLine($"Ваш квадрат: {square2}");

/*1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.

a = 25; b = 5 -> да
a = 2 b = 10 -> нет
a = 9; b = -3 -> да
a = -3 b = 9 -> нет*/

Console.Write("Введите первое число: ");
int first = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе число: ");
int second = int.Parse(Console.ReadLine()!);
if (first == Convert.ToInt32(Math.Pow(second, 2)))
{
    Console.WriteLine("Да");
}
else Console.WriteLine("Нет");

/* Напишите программу, которая будет выдавать название дня недели по заданному номеру.
3 -> Среда
5 ->  Пятница*/

Console.Write("Номер дня недели: ");
int den = int.Parse(Console.ReadLine()!);
if(den == 1){
    Console.WriteLine("Понедельник");
}
if(den == 2){
    Console.WriteLine("Вторник");
}
if(den == 3){
    Console.WriteLine("Среда");
}
if(den == 4){
    Console.WriteLine("Четверг");
}
if(den == 5){
    Console.WriteLine("Пятница");
}
if(den == 6){
    Console.WriteLine("Суббота");
}
if(den == 7){
    Console.WriteLine("Воскресенье");
}
else if(den<1 || den>7){
    Console.WriteLine("Некоректный номер дня");
    }

/*И - && (оба верные все работает)
ИЛИ - || (или один или оба верно, остальное ложь)*/

//Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.

//4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
//2 -> " -2, -1, 0, 1, 2"

Console.Write("Ваше число: ");
int nmbr = int.Parse(Console.ReadLine()!);
int negnmbr = - nmbr;
while(negnmbr <= nmbr){
    Console.Write($"{negnmbr}");
    negnmbr ++;
}

// Console.Write("Ваше трехзначное число: ");
// int nmbr = int.Parse(Console.ReadLine()!);

// % - деление с остатком
// /- деление
Console.WriteLine($"Последняя цифра: {nmbr} равна: {nmbr%10}");