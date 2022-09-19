﻿// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях. [3, 7, 23, 12] -> 19, [-4, -6, 89, 6] -> 0
// 3 на позиции 0. for (int i = ?; i < ?; i += 2)

Console.Write("Предложите количество элементов в массиве: ");
int count = int.Parse(Console.ReadLine()!);

// Задаём одномерный массив, заполненный случайными числами
int[] array = new int[count]; 

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-1000, 1001);
    // Без интервалов определяет слишком большие числа
}

Console.WriteLine($"[{string.Join(", ", array)}]");

// Найдём сумму элементов, стоящих на нечётных позициях
int OddIndSum = 0;
for (int i = 0; i < array.Length; i++)
{
    if (i % 2 != 0) // отсчёт начинается с нуля!
    {
        OddIndSum += array[i];
    }
}
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях, равна {OddIndSum}");
Console.WriteLine();