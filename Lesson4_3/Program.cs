using System;

// Ведров Дмитрий

// Задание 3.

namespace Lesson4_3
{
    class MyArray
    {
        int[] a;
         
        public MyArray(int n, int el)
        {
            a = new int[n];
            for (int i = 0; i < n; i++)
                a[i] = el;
        }
        
        /*
        public MyArray(int n, int min, int max)
        {
            a = new int[n];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
                a[i] = rnd.Next(min, max);
        }
        */

        // Задание 3а. Создание массива определенного размера с заданным шагом.
        public MyArray(int n, int min, int step)
        {
            a = new int[n];
            a[0] = min;
            for (int i = 1; i < a.Length; i++)
            {
                a[i] = a[i - 1] + step;
            }
            foreach (int el in a)
            {
                Console.Write(el + " ");
            }            
        }
        // Задание 3а. Свойство Sum, которое возвращает сумму элементов массива.
        public int Sum
        {
            get
            {
                int sum = a[0];
                for (int i = 1; i <a.Length; i++)
                {
                    sum += a[i];
                }
                return sum;
            }
        }
        // Задание 3а.
        public int[] Inverse(int[] n)
        {
            int[] array = new int[n.Length];
            for (int i = 0; i < n.Length; i++)
            {
                array[i] = -n[i];
            }
            return array;
        }
        // Задание 3а.
        public void Multi(int[] n, int num)
        {
            for (int i = 0; i < n.Length; i++)
            {
                n[i] *= num;
            }
        }
        // Задание 3а.
        public int MaxCount
        {
            get
            {
                int count = 0;
                for (int i = 0; i < a.Length; i++)
                {
                    int num = 0;
                    for (int j = 1; j < a.Length; j++)
                    {                        
                        if (a[j] == a[i])
                        {
                            num++;
                        }
                    }
                    if (num > count) count = num;
                }
                return count;
            }
        }
        public int Max
        {
            get
            {
                int max = a[0];
                for (int i = 1; i < a.Length; i++)
                    if (a[i] > max) max = a[i];
                return max;
            }
        }
        public int Min
        {
            get
            {
                int min = a[0];
                for (int i = 1; i < a.Length; i++)
                    if (a[i] < min) min = a[i];
                return min;
            }
        }
        public int CountPositiv
        {
            get
            {
                int count = 0;
                for (int i = 0; i < a.Length; i++)
                    if (a[i] > 0) count++;
                return count;
            }
        }
        public override string ToString()
        {
            string s = "";
            foreach (int v in a)
                s = s + v + " ";
            return s;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyArray a = new MyArray(10, 0, 100);
            Console.WriteLine(a.ToString());
            Console.WriteLine(a.Max);
            Console.WriteLine(a.Min);
            Console.WriteLine(a.CountPositiv);
            Console.WriteLine();
            Console.WriteLine(a.MaxCount);
            Console.WriteLine(a.Sum);

        }

    }
}
