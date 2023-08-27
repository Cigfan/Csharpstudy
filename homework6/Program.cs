/*Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь. 
(Можно изучить метод Split).
Пример: stringArray.Split(' ', StringSplitOptions.RemoveEmptyEntries);, 
где первый аргумент это разделитель чисел, второе обработчик введеной последовательности)
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 4*/
// Console.Write("Введите Ваши числа через запятую: ");
// //string nums = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
// string[] numbers = Console.ReadLine().Split(',');
// Console.Write(counter(numbers));

// //method
// int[] counter(string numbers){   
//     int ord = 0;
//     int res = 0;
//     for(int i = 0; i <= nums.Length; i++){
//          int ord = int.Parse(nums[i]);
//          if(ord > 0) res++;
//          res + 0;
//          ord++;
//     }
//     return res;
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

int[] answer = Solution(b1, b2, k1, k2);
Console.Write($"[{String.Join(";", answer)}]");


//method
int[] Solution(int b1, int b2, int k1, int k2){
    int x = (k1 - k2) / (b1-b2);;
    int y = k1 * x + b1;;
    int[] cross = new int[2];
    cross[0] = x;
    cross[1] = y;
    return cross;
}