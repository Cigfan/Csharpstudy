// //Напишите программу, которая будет принимать на вход 
// //число и возвращать сумму его цифр.

// Console.WriteLine("Введите число: ");
// int number = int.Parse(Console.ReadLine()!);

// Console.WriteLine($"Сумма цифр в числе {number} - {SumNumbers(number)}");

// int SumNumbers(int numbers){
//     if(numbers == 0) return 0;
//     return (numbers % 10 + SumNumbers(numbers / 10));
// }
// **Задача 1:** Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

// Console.WriteLine("Введите число: ");
// int omega = int.Parse(Console.ReadLine()!);
// Console.WriteLine(Answer(1, omega));

// //method
// string Answer(int alpha, int numbers){
//     if(alpha == numbers) return alpha.ToString();
//     return (alpha +", "+ Answer(alpha + 1, numbers));
// }

// // **Задача 2:** Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

// // M = 1; N = 5. -> "1, 2, 3, 4, 5"
// // M = 4; N = 8. -> "4, 5, 6, 7, 8"


// Console.WriteLine("Введите число: ");
// int m = int.Parse(Console.ReadLine()!);

// Console.WriteLine("Введите число: ");
// int n = int.Parse(Console.ReadLine()!);

// Console.WriteLine(PrintNumbers(m, n));

// string PrintNumbers(int m, int n){
//     if(m == n) return m.ToString();
//     return (m + ", " + PrintNumbers(m + 1, n));
// }
// **Задача 3:** Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.

// A = 3; B = 5 -> 243 (3⁵)

// A = 2; B = 3 -> 8

Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());

Console.WriteLine("Введите степень: ");
int range = int.Parse(Console.ReadLine());

Console.WriteLine($"{Pow(number, range)}");

int Pow(int number, int range){
    if(range == 0) return 1;
    if(range == 1) return number;
    return (number * Pow(number, range - 1));
}