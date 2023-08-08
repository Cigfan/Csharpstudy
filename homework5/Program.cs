/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество 
чётных чисел в массиве.
[345, 897, 568, 234] -> 2*/

int[] box = Randoms(8, 100, 999);
Console.WriteLine($"[{String.Join(",", box)}]");

int counter = 0;

for(int i = 0; i < box.Length; i++){
     if (box[i] % 2 == 0) counter++;
}
Console.Write(counter);

//method
int[] Randoms(int size, int minValue, int maxValue){
    int[] result = new int[size];
    for(int i = 0; i < size; i++){
        result[i] = new Random().Next(minValue, maxValue + 1);
    }
    return result;
}

/*Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных индексах.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0*/

int[] hako = Randoms(8, 10, 99);
Console.WriteLine($"[{String.Join(",", hako)}]");

int sum = 0;

foreach(int el in hako){
    if(el % 2 != 0) sum = sum + el;
}

Console.Write(sum);

//method
int[] Randoms(int size, int minValue, int maxValue){
    int[] result = new int[size];
    for(int i = 0; i < size; i++){
        result[i] = new Random().Next(minValue, maxValue + 1);
    }
    return result;
}

/*Задача 38: Задайте массив целых чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3, 4, 1, 77, 65] => 77 - 1 = 76*/

int[] korob = Randoms(8, 10, 99);
Console.WriteLine($"[{String.Join(",", korob)}]");

int alpha = korob[1];
int omega = korob[1];
int result = 0;

foreach(int el in korob){
    if(el > alpha) alpha = el;
    if(el < omega) omega = el;
}

result = alpha - omega;

Console.Write(result);

//method
int[] Randoms(int size, int minValue, int maxValue){
    int[] result = new int[size];
    for(int i = 0; i < size; i++){
        result[i] = new Random().Next(minValue, maxValue + 1);
    }
    return result;
}