/*// **Задача 46:** Задайте двумерный массив размером m×n, заполненный случайными целыми числами.

// m = 3, n = 4.

// 1 4 8 19

// 5 -2 33 -2

// 77 3 8 1
Console.WriteLine("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine()!);


Console.WriteLine("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);



// Создание массива
int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] res = new int[m,n];
    for(int i = 0; i < m; i++){
        for(int j = 0; j < n; j++){
            res[i,j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return res;
}
// Печать массива
void PrintArray(int[,] array){
    for(int i = 0; i < array.GetLength(0); i++){
        for(int j = 0; j < array.GetLength(1); j++){
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}*/

/***Задача 48:** Задайте двумерный массив размера m на n, каждый элемент в массиве находится 
по формуле: A(I,j) = i+j. Выведите полученный массив на экран.
m = 3, n = 4.
0 1 2 3
1 2 3 4
2 3 4 5*/

/*/ **Задача 48:** Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: A(I,j) = i+j. Выведите полученный массив на экран.

// m = 3, n = 4.

// 0 1 2 3

// 1 2 3 4

// 2 3 4 5

Console.Write("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int columns = int.Parse(Console.ReadLine());

int[,] array = GetArray(rows, columns);
PrintArray(array);

int[,] GetArray (int rows, int columns){
    int[,] result = new int[rows,columns];
    for (int i = 0; i < rows; i++){
        for (int j = 0; j < columns; j++){
            result[i,j] = i + j;
        }
    }
    return result;
}

void PrintArray (int[,] array){
    for (int i = 0; i < array.GetLength(0); i++){
        for (int j = 0; j < array.GetLength(1); j++){
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}*/

// // Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти 
// // элементы на их квадраты.

// Console.WriteLine("Введите количество строк Вашего массива: ");
// int rows = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите количество столбцов Вашего массива: ");
// int columns = int.Parse(Console.ReadLine()!);

// int[,] array = GetArray(rows, columns, 0, 10);
// PrintArray(array);
// Console.WriteLine();
// int[,] changed = NewArray(array);
// PrintArray(changed);


// //mass method
// int[,] GetArray(int rows, int columns, int minValue, int maxValue){
//     int[,] result = new int[rows,columns];
//     for(int i = 0; i < rows; i++){
//         for(int j = 0; j < columns; j++){
//             result[i,j] = new Random().Next(minValue,maxValue + 1);
//         }
//     }
//     return result;
// }

// //print method
// void PrintArray(int[,] array){
//     for(int i = 0; i < array.GetLength(0); i++){
//         for(int j = 0; j < array.GetLength(1); j++){
//             Console.Write($"{array[i,j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// //check method(int)
// int[,] NewArray(int[,] array){
//     int[,] newarray = new int[array.GetLength(0), array.GetLength(1)];
//     for(int i = 0; i < array.GetLength(0); i++){
//         for(int j = 0; j < array.GetLength(1); j++){
//             if(i % 2 == 0 && j % 2 == 0) newarray[i,j] = array[i,j] * array[i,j];
//             else newarray[i,j] = array[i,j];
//         }
//     }
//     return newarray;
// }

// // **Задача 51:** Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.

// // Например, задан массив:

// // 1 4 7 2

// // 5 9 2 3

// // 8 4 2 4

// // Сумма элементов главной диагонали: 1+9+2 = 12

// Console.WriteLine("Введите количество строк Вашего массива: ");
// int rows = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите количество столбцов Вашего массива: ");
// int columns = int.Parse(Console.ReadLine()!);

// int[,] array = GetArray(rows, columns, 0, 9);
// PrintArray(array);
// DiagonalSum(array);
// int[,] GetArray(int rows, int columns, int minValue, int maxValue){
//     int[,] result = new int[rows,columns];
//     for(int i = 0; i < rows; i++){
//         for(int j = 0; j < columns; j++){
//             result[i,j] = new Random().Next(minValue,maxValue + 1);
//         }
//     }
//     return result;
// }

// void PrintArray(int[,] array){
//     for(int i = 0; i < array.GetLength(0); i++){
//         for(int j = 0; j < array.GetLength(1); j++){
//             Console.Write($"{array[i,j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// void DiagonalSum (int[,] array){
//     int sum = 0;
//     for(int i = 0; i < array.GetLength(0); i++){
//         for(int j = 0; j < array.GetLength(1); j++){
//             if (i == j) sum += array[i,j];
//         }
//     }
//     Console.WriteLine(sum);
// }