﻿// Задача 64: Задайте значение N. 
// Напишите программу, которая выведет в
// се натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


Console.Clear();

Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());

string result = Subsequence(N, 1);
Console.Write(result);

string Subsequence(int start, int end)
{
    if (end == start)
    {
        return end.ToString();       
    }
    return start + " " + Subsequence(start - 1, end);
}