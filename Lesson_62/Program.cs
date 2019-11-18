using System;
using System.IO;

// Ведров Дмитрий
// Задание 2.

namespace Lesson_62
{
    public delegate double Function(double f);

    class Program
    {
        public static double F1(double x)
        {
            return x * x - 50 * x + 10;
        }
        public static double F2(double x)
        {
            return x * x * 0.5 * x * 0.1;
        }
        public static void SaveFunc(string fileName, double a, double b, double h, Function f)
        {
            FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);
            double x = a;
            while (x <= b)
            {
                bw.Write(f(x));
                x += h;// x=x+h;
            }
            bw.Close();
            fs.Close();
        }
        public static double Load(string fileName)
        {
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            BinaryReader bw = new BinaryReader(fs);
            double min = double.MaxValue;
            double d;
            for (int i = 0; i < fs.Length / sizeof(double); i++)
            {
                // Считываем значение и переходим к следующему
                d = bw.ReadDouble();
                if (d < min) min = d;
            }
            bw.Close();
            fs.Close();
            return min;
        }
        static void Main(string[] args)
        {
            Function[] func = { F1, F2 };
            Console.WriteLine("Выберите от какой функции посчитать ее мининмум.\n1 - F1(x * x - 50 * x + 10)\n2 - F2(x * x * 0.5 * x * 0.1)");
            int number = int.Parse(Console.ReadLine());
            SaveFunc("data.bin", -100, 100, 0.5, func[number - 1]);
            Console.WriteLine(Load("data.bin"));
            Console.ReadKey();
        }
    }
}
