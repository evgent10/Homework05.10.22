Console.Clear();
// //Задача 41:
// // Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел 
// // больше 0 ввёл пользователь. 0, 7, 8, -2, -2 -> 2   1, -7, 567, 89, 223-> 4
// Console.Write("Введите размер массива: ");
// int size = int.Parse(Console.ReadLine()!);
// int[] num = newRandom(size);
// int count = 0;

// Console.WriteLine($"В массиве {size} элементов, а именно: [{String.Join(", ", (num))}]");

// int[] newRandom(int size)
// {
//     int[] array = new int[size];
//     for (int i =0; i< array.Length; i++)
//     {
//         array[i] = new Random().Next(-100, 100);
//     }
//     return array;
// }

// for ( int j = 0; j < num.Length; j++ ) 
// {
//      if (0 < num[j]) 
//      count++;
         
// }
                         
// Console.WriteLine($"Больше нуля = {count}");



// Задача 43:
// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 
// задаются пользователем.    b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double pointX;
double pointY;
                             
Console.Write("Введите точки b1, k1, b2 и k2 через пробел: ");
int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
int b1 = arr [0];
int k1 = arr [1];
int b2 = arr [2];
int k2 = arr [3];

if ((k1 == k2) && (b1 == b2))
{
    Console.WriteLine("Прямые с такими параметрами паралельны");
}
else
{

    pointX = (double) (b2-b1)/(k1-k2);
    pointY = (double) k1*(b2-b1)/(k1-k2) + b1;
    Console.WriteLine("Координаты точки пересечения двух прямых:");
    Console.WriteLine($"Х: {pointX:0.00}");
    Console.WriteLine($"Y: {pointY:0.00}");
}