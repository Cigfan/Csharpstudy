// Console.Write("Введите Ваше число А: ");
// int A = int.Parse(Console.ReadLine()!);
// Console.WriteLine($"Сумма чисел от 1 до {A} равна {GetSum(A)}");

// //Методы
// int GetSum(int A){
//     int sum = 0;
//     for(int i = 1; i <= A; i++){
//         sum += i;
//     }
//     return sum;
// }

// Задача 1: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.

// 4  -> 24
// 5  -> 120

// Console.Write("Введите Ваше число: ");
// int omega = int.Parse(Console.ReadLine()!);
// Console.WriteLine($"Произведения чисел от 1 до {omega} равна {MyMethod(omega)}");

// //method
// int MyMethod(int omega) {
//     int sum = 1;
//     for(int i = 1; i <= omega; i++){
//         sum *= i;
//     }
//     return sum;
// }

// Задача 2: Определить, является ли заданное шестизначное число счастливым. 
// (Счастливым называют такое шестизначное число, что сумма его первых трех цифр равна сумме его 
// последних трех цифр, порядок чисел в сумме не важен). Решить самым оптимальным способом.

Console.WriteLine("Введите шестизначное число: ");
int N = int.Parse(Console.ReadLine()!);
if(N >= 100000 && N <= 999999){
    if (LuckyNumber(N) == true) Console.WriteLine($"Число {N} - счастливое");
    else Console.WriteLine($"Число {N} - не счастливое");
}
else Console.WriteLine("Некорректный ввод");

bool LuckyNumber(int num){
    string number = num.ToString();
    int first = (Convert.ToInt32(number[0]) + Convert.ToInt32(number[1]) + Convert.ToInt32(number[2]));
    int second = (Convert.ToInt32(number[3]) + Convert.ToInt32(number[4]) + Convert.ToInt32(number[5]));

    if (first == second){
        return true;
    }
    return false;
}

// Задача 3: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.

// [1,0,1,1,0,1,0,0]

int[] array = GetRange(8);
Console.WriteLine($"[{String.Join(",", array)}]");

//method
int[] GetRange(int size){
    int[] massive = new int[size];
    for(int i = 0; i < massive.Length; i++){
        massive[i] = new Random().Next(2);
    }
    return massive;
}