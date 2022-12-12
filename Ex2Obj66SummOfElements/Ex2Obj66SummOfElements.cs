// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт 
// сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


Console.Clear();

Console.WriteLine("Введите начальное число: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите конечное число: ");
int M = Convert.ToInt32(Console.ReadLine());
int temp2 = 0;
int result = Subsequence(N, M);
Console.Write(result);

int Subsequence(int start, int end)
{
    if (start == end) return start;
    else if (start < end) return end + Subsequence(start, end - 1);
    else return end + Subsequence(start, end + 1);
}