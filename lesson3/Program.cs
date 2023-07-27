/*Console.Write("Введите день недели");
int number = int.Parse(Console.ReadLine()!);

switch (number){
    case 6:{
        Console.WriteLine("Это суббота");
        break;
    }
    case 7:{
        Console.WriteLine("Это воскресенье");
        break;
    }
    default:{
        Console.WriteLine("Это будний день.");
        break;
    }
}
*/

/*Задача 1: Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).*/

// Console.Write("Введите номер четверти: ");
// int quarter = int.Parse(Console.ReadLine()!);
// switch (quarter){
//     case 1:{
//         Console.WriteLine("Координаты X и Y больше нуля.");
//         break;
//     }
//     case 2:{
//         Console.WriteLine("Координаты Y болше нуля, а X меньше нуля");
//         break;
//     }    
//     case 3:{
//         Console.WriteLine("Координаты X и Y меньше нуля.");
//         break;
//     }    
//     case 4:{
//         Console.WriteLine("Координаты X болше нуля, а Y меньше нуля");
//         break;
//     }
//     default:{
//         Console.WriteLine("Номер четверти не корректен.");
//         break;
//     }
// }


/*Задача 2: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
A (3,6); B (2,1) -> 5,09
A (7,-5); B (1,-1) -> 7,21*/

// Console.Write("Введите X координаты точки А: ");
// int coordAX = int.Parse(Console.ReadLine()!);
// Console.Write("Введите Y координаты точки А: ");
// int coordAY = int.Parse(Console.ReadLine()!);
// Console.Write("Введите X координаты точки B: ");
// int coordBX = int.Parse(Console.ReadLine()!);
// Console.Write("Введите X координаты точки B: ");
// int coordBY = int.Parse(Console.ReadLine()!);
// //AB = √(xb - xa)2 + (yb - ya)2
// double AB = Math.Sqrt(Math.Pow((coordBX - coordAX),2) + Math.Pow((coordBY - coordAY),2));

// //Чтобы обрезать число double до какого-то определенного числа в выводе указываем так ($"{double:fN}"), где N - количество цифр после запятой.

// Console.WriteLine ($"{AB:f2}");

/*Задача 3: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
5 -> 1, 4, 9, 16, 25.
2 -> 1,4*/

Console.Write("Введите Ваше число: ");
int Omega = int.Parse(Console.ReadLine()!);
int Alpha = 1;
while(Alpha <= Omega){
    Console.Write($"{Math.Pow(Alpha, 2)} ");
    Alpha ++;
}
