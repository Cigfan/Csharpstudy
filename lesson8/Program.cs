/**Задача 1:** Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

В итоге получается вот такой массив:
8 4 2 4
5 9 2 3
1 4 7 2*/

// int[,] matrix = GetArray(4, 3);
// PrintArray(matrix);
// Console.WriteLine();
// PrintReverse(matrix);
// PrintArray(matrix);

// int[,] GetArray(int m, int n){
//     int[,] matrix = new int[m, n];
//     for(int i = 0; i < matrix.GetLength(0); i++){
//         for(int j = 0; j < matrix.GetLength(1); j++){
//             matrix[i, j] = new Random().Next(1, 9);
//         }
//     }
//     return matrix;
// }

// void PrintArray(int[,] matrix){
//     for(int i = 0; i < matrix.GetLength(0); i++){
//         for(int j = 0; j < matrix.GetLength(1); j++){
//             Console.Write($"{matrix[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// void PrintReverse(int[,] matrix){
//     int[] temp = new int[matrix.GetLength(0)];
//     for(int j = 0; j < matrix.GetLength(1); j++){
//         temp[j] = matrix[0, j];
//         matrix[0, j] = matrix[matrix.GetLength(0)-1, j];
//         matrix[matrix.GetLength(0)-1, j] = temp[j];
//     }        
// }

/**Задача 2:** Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае, если это невозможно, программа должна вывести сообщение для пользователя.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7

В итоге получается вот такой массив:
1 5 8 5
4 9 4 2
7 2 2 6
2 3 4 7*/


int[,] matrix = GetArray(4, 3);
PrintArray(matrix);
Console.WriteLine();
PrintArray(TurnedMassive(matrix));


//methods
int[,] GetArray(int m, int n){
    int[,] matrix = new int[m, n];
    for(int i = 0; i < matrix.GetLength(0); i++){
        for(int j = 0; j < matrix.GetLength(1); j++){
            matrix[i, j] = new Random().Next(1, 9);
        }
    }
    return matrix;
}

void PrintArray(int[,] matrix){
    for(int i = 0; i < matrix.GetLength(0); i++){
        for(int j = 0; j < matrix.GetLength(1); j++){
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] TurnedMassive(int[,] matrix){
    if(matrix.GetLength(0) == matrix.GetLength(1)){
        int[,] temparray = new int[matrix.GetLength(1), matrix.GetLength(0)];
        for(int i = 0; i < matrix.GetLength(0); i++){
            for(int j = 0; j < matrix.GetLength(1); j++){
                temparray[i,j] = matrix[j,i];
            }
        }
    return temparray;
    }
    else {
        Console.WriteLine("Переворот невозможен");
        return matrix;
    }
}

// Задача 3: Из двумерного массива целых чисел удалить строку и столбец, на пересечении которых расположен наименьший элемент.

int[,] matrix = GetArray(5, 5);
PrintArray(matrix);
Console.WriteLine();
Console.WriteLine($"{String.Join(", ", FindMin(matrix))}");
Console.WriteLine();
PrintArray(TrimmArray(matrix, FindMin(matrix)));

int[,] GetArray(int m, int n){
    int[,] matrix = new int[m, n];
    for(int i = 0; i < matrix.GetLength(0); i++){
        for(int j = 0; j < matrix.GetLength(1); j++){
            matrix[i, j] = new Random().Next(1, 9);
        }
    }
    return matrix;
}

void PrintArray(int[,] matrix){
    for(int i = 0; i < matrix.GetLength(0); i++){
        for(int j = 0; j < matrix.GetLength(1); j++){
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}
int[] FindMin (int[,] matrix){
    int minValue = matrix[0,0];
    int[] minIndex = new int[2];
    for(int i = 0; i < matrix.GetLength(0); i++){
        for(int j = 0; j < matrix.GetLength(1); j++){
            if (matrix[i, j] < minValue){
                minValue = matrix[i, j];
                minIndex[0] = i;
                minIndex[1] = j;
            }
        }
    }
    return minIndex;
}

int[,] TrimmArray(int[,] matrix, int[] minIndex){
    int[,] result = new int[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];
    int row = 0;
    int columns = 0;
    for(int i = 0; i < matrix.GetLength(0); i++){
        if(i == minIndex[0]) continue;
        for(int j = 0; j < matrix.GetLength(1); j++){
            if(j == minIndex[1]) continue;
            result[row,columns] = matrix[i,j];
            columns++;
        }
        columns = 0;
        row++;
    }
    return result;
}
