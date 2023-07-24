/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1*/

Console.Write("Введите трезначное число: ");
int trio = int.Parse(Console.ReadLine()!);
string triostring = trio.ToString();
if(triostring.Length == 3){
    Console.WriteLine(triostring[1]);
}
else Console.WriteLine("Число не корректно.");

/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6*/

Console.Write("Введите трезначное число: ");
int quad = int.Parse(Console.ReadLine()!);
string quadstring = quad.ToString();
if(quadstring.Length == 3){
    Console.WriteLine(quadstring[2]);
}
else Console.WriteLine($"В числе {quadstring} третьей цифры нет.");

/*Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, 
является ли этот день выходным.
6 -> да
7 -> да
1 -> нет*/

Console.Write("Введите номер дня недели: ");
int week = int.Parse(Console.ReadLine()!);
if (week > 0 && week < 8)
{
    string result = (week == 6 || week == 7 ? "Выходной" : "Рабочий день");
    Console.WriteLine(result);
}
else Console.WriteLine("Вы ввели некорректный день недели.");
