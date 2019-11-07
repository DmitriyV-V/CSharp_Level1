using System;
using System.IO;

// Ведров Дмитрий

// Задание 1. Задание 2.

namespace Lesson4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Example_1.Ex(20);
            Console.WriteLine();
            Example_1.ParseFile();
        }
    }
    //Задание 2а. Реализация задачи 1 в виде статического класса.
    static class Example_1
    {
        // Задание 1. Создание массива со случайными числами.
        public static void Ex(int n)
        {
            int[] array = new int[n];
            Random random = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(-10000, 10000);
            }
            Console.WriteLine("Массив из 20 элементов:");
            foreach (int el in array)
            {
                Console.Write(el + ", ");
            }

            Console.WriteLine();
            Console.WriteLine("Пары элементов массива:");
            for (int j = 1; j < array.Length; j++)
            {
                if (array[j] % 3 == 0 && array[j - 1] % 3 != 0 || array[j] % 3 != 0 && array[j - 1] % 3 == 0)
                {
                    Console.Write(array[j] + " и " + array[j - 1] + "; ");
                }
            }
        }
        // Задание 2б. Считывание массива целых чисел из файла.
        // Задание 2в. Обработка ситуации отсутствия файла на диске.
        public static void ParseFile()
        {
            int[] arr;
            try
            {
                StreamReader sr = new StreamReader("C:\\Users\\1\\Desktop\\Учеба\\C#\\data.txt");
                int number = int.Parse(sr.ReadLine());
                arr = new int[number];
                for (int i = 1; i < arr.Length; i++)
                {
                    arr[i] = int.Parse(sr.ReadLine());                    
                }
                foreach (int elem in arr)
                {
                    Console.Write(elem + " ");
                }                
                sr.Close();
            }
            catch (Exception exept)
            {
                Console.WriteLine(exept.Message);
            }
        }            
    }
}
