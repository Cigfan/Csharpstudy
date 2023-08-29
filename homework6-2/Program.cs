// Задача 41: Пользователь вводит с клавиатуры N чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.

// Console.Write("Введите числа через пробел: ");
// int[] numbers = GetArrayFromString(Console.ReadLine()!);
// Console.WriteLine($"Количество чисел больше 0 –> {GetCountPositiveElements(numbers)}");
// Console.WriteLine();


// int[] GetArrayFromString(string stringArray)
// {
//     string[] numS = stringArray.Split(' ', StringSplitOptions.RemoveEmptyEntries);
//     int[] result = new int[numS.Length];
//     for (int i = 0; i < result.Length; i++)
//     {
//         result[i] = int.Parse(numS[i]);
//     }
//     return result;
// }

// int GetCountPositiveElements(int[] array)
// {
//     int count = 0;
//     foreach (var item in array)
//     {
//         if(item>0) count++;
//     }
//     return count;
// }

/*Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)*/

Console.Write("Введите координату b1: ");
int b1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите координату b2: ");
int b2 = int.Parse(Console.ReadLine()!);
Console.Write("Введите координату k1: ");
int k1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите координату k2: ");
int k2 = int.Parse(Console.ReadLine()!);

int x = (b1 - b2) / (k1 - k2);
Console.Write(x);

// int[] answer = Solution(b1, b2, k1, k2);
// Console.Write($"[{String.Join(";", answer)}]");


// //method
// int[] Solution(int b1, int b2, int k1, int k2){
//     int x = (b1 - b2) / (k1 - k2);
//     int y = k1 * x + b1;
//     int[] cross = new int[2];
//     cross[0] = x;
//     cross[1] = y;
//     return cross;
// }