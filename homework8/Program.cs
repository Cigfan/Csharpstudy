/*Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2*/

int[,] array = GetArray(4, 4, 0, 9);
Console.WriteLine("Начальный массив:");
PrintArray(array);
int[,] sorted = Sorting(array);
Console.WriteLine("Отсортированный массив:");
PrintArray(sorted);
Console.WriteLine();
/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка*/

int[,] raw = GetArray(4, 4, 0, 9);
PrintArray(raw);
int please = calculum(raw);
int Costyl = Cane(please, raw);
Console.WriteLine($"Номер строки с наименьшей суммой элементов: {Costyl} строка");
Console.WriteLine();

/*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18*/

Console.WriteLine("Первая матрица:");
int[,] matrix1 = GetArray(2, 2, 1, 5);
PrintArray(matrix1);
Console.WriteLine("Вторая матрица:");
int[,] matrix2 = GetArray(2, 2, 1, 5);
PrintArray(matrix2);
Console.WriteLine("Перемноженная матрица:");
int[,] done = Answer(matrix1, matrix2);
PrintArray(done);
Console.WriteLine();

/*Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, 
добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)*/

Console.WriteLine("Трёхмерный массив: ");
int[,,] cubic = Get3DArray(2, 2, 2, 10, 99);
Print3DArray(cubic);
Console.WriteLine();

/*Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07*/

Console.WriteLine("Спираль:");
int[,] spiral = GetSpiral(6, 6);
PrintArray(spiral);

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
//printarray
void PrintArray(int[,] array){
    for(int i = 0; i < array.GetLength(0); i++){
        for(int j = 0; j < array.GetLength(1); j++){
            int f = array[i,j];
            Console.Write($"{f.ToString("D2")} ");
        }
        Console.WriteLine();
    }
}
//MatrixMulti
int[,] Answer(int[,] matrix1, int[,] matrix2){
    int[,] calculation = new int[2,2];
    calculation[0,0] = matrix1[0,0] * matrix2[0,0] + matrix1[0,1] * matrix2[1,0];
    calculation[0,1] = matrix1[0,0] * matrix2[0,1] + matrix1[0,1] * matrix2[1,1];
    calculation[1,0] = matrix1[1,0] * matrix2[0,0] + matrix1[1,1] * matrix2[1,0];
    calculation[1,1] = matrix1[1,0] * matrix2[0,1] + matrix1[1,1] * matrix2[1,1];
    return calculation;
}
//3dArray
int[,,] Get3DArray(int m, int n, int l, int minValue, int maxValue){
    int[,,] res = new int[m,n,l];
    for(int i = 0; i < m; i++){
        for(int j = 0; j < n; j++){
            for(int k = 0; k < l; k++){
                res[i,j,k] = new Random().Next(minValue, maxValue + 1);
            }
        }
    }
    return res;
}
//print3DArray
void Print3DArray(int[,,] array){
    for(int i = 0; i < array.GetLength(0); i++){
        for(int j = 0; j < array.GetLength(1); j++){
            for(int k = 0; k < array.GetLength(2); k++){
                Console.Write($"{array[i,j,k]}({i},{j},{k}) ");
            }
        }
        Console.WriteLine();
    }
}
//spiralarray
int[,] GetSpiral(int m, int n){
    int count = 1;
    int[,] res = new int[m,n];
    int a = 0;
    int b = 0;
    int x = res.GetLength(0) - 1;
    int y = res.GetLength(1) - 1;
    while(a < x && b < y){
        for(int i = b; i <= y; i++){
            res[a,i] = count++;
        }
        a++;
        for(int i = a; i <= x; i++){
            res[i,y] = count++;
        }
        y--;
        for(int i = y; i >= b; i--){
            res[x,i] = count++;
        }
        x--;
        for(int i = x; i >= a; i--){
            res[i,b] = count++;
        }
        b++;
    }
    return res;
}
//calculating
int calculum(int[,] array){
    int sums = 0;
    int mins = 999;
    for(int i = 0; i < array.GetLength(0); i++){
        for(int j = 0; j < array.GetLength(1); j++){
            sums += array[i,j];
        }
        if(sums < mins) mins = sums;
        sums = 0;
    }
    return mins;
}
//Cane
int Cane(int please, int[,] array){
    int sum = 0;
    int index = 0;
    for(int i = 0; i < array.GetLength(0); i++){
        for(int j = 0; j < array.GetLength(1); j++){
            sum += array[i,j];
            }
        if(sum == please)index = i + 1;
        else sum = 0;
    }
    return index;
}
//sort
int[,] Sorting(int[,] array){
    int check = 0;
    int ctdw = 0;
    while(ctdw < array.GetLength(0)){
        for(int i = 0; i < array.GetLength(0); i++){
            for(int j = 0; j < array.GetLength(1); j++){
                if(j < array.GetLength(1) - 1 && array[i,j] < array[i,j+1]){
                    check = array[i,j];
                    array[i,j] = array[i,j+1];
                    array[i,j+1] = check;
                }
            }
        }
        ctdw++;   
    }
    return array;
}

// int[,] GetMultiplicationMatrix(int[,] arrayA, int[,] arrayB)
// {
//     int[,] arrayC = new int[arrayA.GetLength(0), arrayB.GetLength(1)];
//     for (int i = 0; i < arrayA.GetLength(0); i++)
//     {
//         for (int j = 0; j < arrayB.GetLength(1); j++)
//         {
//             for (int k = 0; k < arrayA.GetLength(1); k++)
//             {
//                 arrayC[i, j] += arrayA[i, k] * arrayB[k, j];
//             }
//         }
//     }
//     return arrayC;
// }