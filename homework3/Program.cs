/*Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом(первое == последнему, второе == предпоследнему).
14212 -> нет
12821 -> да
23432 -> да*/

Console.Write("Введите пятизначное число: ");
int penta = int.Parse(Console.ReadLine()!);
string pentastring = penta.ToString();
if(pentastring.Length == 5){
    if(pentastring[0] == pentastring[4] && pentastring[1] == pentastring[3]){
        Console.WriteLine("Ваше число - полиндром.");
    }
    else Console.WriteLine("Ваше число не полиндром.");
}
else Console.WriteLine("Ваше число не пятизначное.");

/*Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53*/

Console.Write("Введите X координаты точки А: ");
int coordAX = int.Parse(Console.ReadLine()!);
Console.Write("Введите Y координаты точки А: ");
int coordAY = int.Parse(Console.ReadLine()!);
Console.Write("Введите Z координаты точки А: ");
int coordAZ = int.Parse(Console.ReadLine()!);
Console.Write("Введите X координаты точки B: ");
int coordBX = int.Parse(Console.ReadLine()!);
Console.Write("Введите Y координаты точки B: ");
int coordBY = int.Parse(Console.ReadLine()!);
Console.Write("Введите Z координаты точки B: ");
int coordBZ = int.Parse(Console.ReadLine()!);

double triangle = Math.Sqrt(Math.Pow((coordBX - coordAX),2) + Math.Pow((coordBY - coordAY),2) + Math.Pow((coordBZ - coordAZ),2));

Console.WriteLine ($"{triangle:f2}");

/*Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125*/

Console.Write("Введите Ваше число: ");
int Omega = int.Parse(Console.ReadLine()!);
int Alpha = 1;
while(Alpha < Omega){
    Console.Write($"{Math.Pow(Alpha, 3)}, ");
    Alpha ++;
}
Console.Write($"{Math.Pow(Alpha, 3)}.");