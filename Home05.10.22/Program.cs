Console.Clear();
//Задача 41:
// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел 
// больше 0 ввёл пользователь. 0, 7, 8, -2, -2 -> 2   1, -7, 567, 89, 223-> 4
Console.Write("Введите размер массива: ");
int size = int.Parse(Console.ReadLine()!);
int[] num = newRandom(size);
int count = 0;

Console.WriteLine($"В массиве {size} элементов, а именно: [{String.Join(", ", (num))}]");

int[] newRandom(int size)
{
    int[] array = new int[size];
    for (int i =0; i< array.Length; i++)
    {
        array[i] = new Random().Next(-100, 100);
    }
    return array;
}

for ( int j = 0; j < num.Length; j++ ) 
{
     if (0 < num[j]) 
     count++;
         
}
                         
Console.WriteLine($"Больше нуля = {count}");






// Задача 43:
// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 
// задаются пользователем.    b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
