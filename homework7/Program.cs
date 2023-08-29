/*Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9*/

Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine()!);
double[,] box = GetRealArray(rows, columns, 0, 9);
PrintRealArray(box);
Console.WriteLine();

/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
позиция i = 4, j = 2 -> такой позиции нет
позиция i = 1, j = 0 -> 5*/

int[,] array = GetArray(4, 4, 0, 9);
PrintArray(array);
Console.WriteLine("Введите позиции элемента через пробел: ");
int[] coords = GetArrayFromString(Console.ReadLine()!);
//минус один нужен для ввода конкретной координаты с учётом того что пользователь не задумывается о том, что счёт начинается с 0
if(coords[0] - 1 <= array.GetLength(0) && coords[1] - 1 <= array.GetLength(1)){
    Console.WriteLine($"Ваш элемент - {array[coords[0] - 1,coords[1] - 1]}");
}
else Console.WriteLine("Ваш элемент не существует в данном массиве.");
Console.WriteLine();

/*Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/

int[,] hako = GetArray(4, 4, 0, 9);
PrintArray(hako);
Console.WriteLine();
float total = 0;
int counter = 0;
float answer = 0;
while(counter < hako.GetLength(0)){
    for(int i = 0; i < hako.GetLength(0); i++){
        for(int j = 0; j < hako.GetLength(1); j++){
            if(j == counter) total += hako[i,j];
        }
    }
    answer = total / hako.GetLength(1);
    Console.Write($"{string.Format("{0:F1}", answer)} ");
    total = 0;
    counter++;
}
//array
int[,] GetArray(int m, int n, int minValue, int maxValue){
    int[,] res = new int[m,n];
    for(int i = 0; i < m; i++){
        for(int j = 0; j < n; j++){
            res[i,j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return res;
}
//array
double[,] GetRealArray(int m, int n, int minValue, int maxValue){
    double[,] realres = new double[m,n];
    for(int i = 0; i < m; i++){
        for(int j = 0; j < n; j++){
            realres[i,j] = new Random().Next(minValue, maxValue + 1) + new Random().NextDouble();
        }
    }
    return realres;
}
//printarray
void PrintArray(int[,] array){
    for(int i = 0; i < array.GetLength(0); i++){
        for(int j = 0; j < array.GetLength(1); j++){
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}
//printarray
void PrintRealArray(double[,] array){
    for(int i = 0; i < array.GetLength(0); i++){
        for(int j = 0; j < array.GetLength(1); j++){
            Console.Write($"{string.Format("{0:F1}", array[i,j])} ");
        }
        Console.WriteLine();
    }
}
//scan
int[] GetArrayFromString(string stringArray)
{
    string[] numS = stringArray.Split(' ', StringSplitOptions.RemoveEmptyEntries);
    int[] result = new int[numS.Length];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = int.Parse(numS[i]);
    }
    return result;
}