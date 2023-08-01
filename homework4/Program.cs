/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16*/

// Console.Write("Введите первое число: ");
// int first = int.Parse(Console.ReadLine()!);
// Console.Write("Введите второе число: ");
// int second = int.Parse(Console.ReadLine()!);
// int power = first;
// for(int i = 1; i < second; i++){
//     first *= power;
// }
// Console.Write($"Число {power} в степени {second} равно {first}.");


/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12*/

Console.Write("Введите Ваше число: ");
int raw = int.Parse(Console.ReadLine()!);
string cooked = raw.ToString();
// Console.Write(cooked.Length);
int sum = 0;

for(int i = 0; i < cooked.Length; i++){
    //Convert.ToInt32(cooked[i]) += sum;
    sum = Convert.ToInt32(cooked[i].ToString()) + sum;
}
Console.Write($"{sum}");

// int i = 0;
// while (i < cooked.Length){
//     sum = Convert.ToInt32(cooked[i]) + sum;
//     i++;
// }
// Console.Write($"{sum}");

/*Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. (можно указать любой промежуток)
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]*/

// int[] box = Randoms(8);
// Console.WriteLine($"[{String.Join(",", box)}]");

// //method
// int[] Randoms(int size){
//     int[] massive = new int[size];
//     for(int i = 0; i < massive.Length; i++){
//         massive[i] = new Random().Next(100);
//     }
//     return massive;
// }