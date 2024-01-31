//Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. 
//Использовать рекурсию, не использовать циклы.


using System;

class Program
{
    static void PrintNumbers(int current, int end)
    {
        if (current <= end)
        {
            Console.Write(current + " ");
            PrintNumbers(current + 1, end);
        }
    }
    static void Main(string[] args)
    {
        Console.Write("Input start of sequence: ");
        int M = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input end of sequence: ");
        int N = Convert.ToInt32(Console.ReadLine());
        PrintNumbers(M, N);
    }
}
