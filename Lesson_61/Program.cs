using System;

// Ведров Дмитрий.
// Задание 1.

namespace Lesson_61
{
    public delegate double Fun(double x);

    // Делегат, принимающий два значения типа double
    public delegate double Fun2(double x, double a);

    class Program
    {
        // Создаем метод, который принимает делегат
        // На практике этот метод сможет принимать любой метод
        // с такой же сигнатурой, как у делегата
        public static void Table(Fun F, double x, double b)
        {
            Console.WriteLine("----- X ----- Y -----");
            while (x <= b)
            {
                Console.WriteLine("| {0,8:0.000} | {1,8:0.000} |", x, F(x));
                x += 1;
            }
            Console.WriteLine("---------------------");
        }
        public static void Table2(Fun2 F, double x, double a, double b)
        {
            Console.WriteLine("----- X ----- Y -----");
            while (x <= b)
            {
                Console.WriteLine("| {0,8:0.000} | {1,8:0.000} |", x, F(x, a));
                x += 1;
            }
            Console.WriteLine("---------------------");
        }
        // Создаем метод для передачи его в качестве параметра в Table
        public static double MyFunc(double x)
        {
            return x * x * x;
        }
        // Задание 1. Функция a*x^2
        public static double MyFunc2(double x, double a)
        {
            return a * x * x;
        }
        // Задание 1. Функция a*sin(x)
        public static double MyFunc3(double x, double a)
        {
            return a * Math.Sin(x);
        }

        static void Main()
        {
            /*
            // Создаем новый делегат и передаем ссылку на него в метод Table
            Console.WriteLine("Таблица функции MyFunc:");

            // Параметры метода и тип возвращаемого значения, должны совпадать с делегатом
            Table(new Fun(MyFunc), -2, 2);

            Console.WriteLine("Еще раз та же таблица, но вызов организован по новому");

            // Упрощение(c C# 2.0).Делегат создается автоматически.            
            Table(MyFunc, -2, 2);

            Console.WriteLine("Таблица функции Sin:");

            Table(Math.Sin, -2, 2);      // Можно передавать уже созданные методы
            
            Console.WriteLine("Таблица функции x^2:");

            // Упрощение(с C# 2.0). Использование анонимного метода
            Table(delegate (double x) { return x * x; }, 0, 3);
            */
            
            Console.WriteLine("Таблица функции a * x^2:");
            Table2(MyFunc2, -2, 1, 2);

            Console.WriteLine("Таблица функции a * sin(x):");
            Table2(MyFunc3, -2, 1, 2);
        }
    }
}
