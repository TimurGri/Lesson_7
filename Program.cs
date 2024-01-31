//Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.


using System;
namespace ReverseArray
{
    class Program
    {
        static int[] GetRandomArray(int len, int min, int max)
        {
            Random rnd = new();
            int[] arr = new int[len];
            for (int i = 0; i < len; i++)
            {
                arr[i] = rnd.Next(min, max);
            }
            return arr;

        }
        static void PrintReverse(int[] arr, int index)
        {
            if (index < 0)
            {
                return;
            }
            Console.Write(arr[index] + " ");
            PrintReverse(arr, index - 1);
        }
        static void PrintArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            Console.Write("Input the length of array: ");
            int len = Convert.ToInt32(Console.ReadLine());
            int min = 10, max = 100;
            int[] arr = GetRandomArray(len, min, max);
            PrintArray(arr);
            PrintReverse(arr, arr.Length - 1);
        }
    }
}