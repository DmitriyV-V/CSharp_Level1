using System;

namespace Lesson_1
{
    class Program
    {
        static void Main(string[] args)
        {
         
            // Ведров Дмитрий



            // Задание 1. Программа "Анкета"

            Console.WriteLine("Программа \"Анкета\"");
            Console.WriteLine("Введите ваше имя:");
            string name = Console.ReadLine();
            Console.WriteLine("Введите вашу фамилию:");
            string surname = Console.ReadLine();
            Console.WriteLine("Введите ваш возраст:");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите ваш рост в см:");
            double height = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите ваш вес в кг:");
            double weight = double.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Вывод методом склеивания:");
            Console.WriteLine("Имя: " + name + " Фамилия: " + surname + " Возраст: " + age + " лет, Рост: " + height + " см, Вес: " + weight + " кг");
            Console.WriteLine("Вывод методом форматирования:");
            Console.WriteLine("Имя: {0} Фамилия: {1} Возраст: {2} лет,Рост: {3} см, Вес: {4} кг",name, surname, age, height, weight);
            Console.WriteLine("Вывод методом $:");
            Console.WriteLine($"Имя: {name} Фамилия: {surname} Возраст: {age} лет, Рост: {height} см, Вес: {weight} кг");
            Console.WriteLine("Вывод методом склеивания:");

            //Задание 2. Расчет индекса массы тела

            double massIndex = weight / ((height / 100) * (height / 100));

            Console.WriteLine();
            Console.WriteLine($"Ваш индекс массы тела равен: {massIndex}");

            //Задание 3. Подсчет расстояния между точками

            Console.WriteLine();
            Console.WriteLine("Подсчет расстояния между точками");
            Console.WriteLine("Значение точки x1:");
            double x1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Значение точки x2:");
            double x2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Значение точки y1:");
            double y1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Значение точки y2:");
            double y2 = double.Parse(Console.ReadLine());


            double distancePoint = DistancePoint(x1, x2, y1, y2);

            Console.WriteLine($"Расстояние между двумя точками равно - {distancePoint:f2}");

            //Задание 4. Обмен значений двух переменных

            Console.WriteLine();
            Console.WriteLine("Обмен значений двух переменных");
            Console.WriteLine("Переменная 1:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Переменная 2:");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine($"а = {a}, b = {b}");

            //Обмен значений двух переменных с использованием третьей переменной
            int c;
            c = a;
            a = b;
            b = c;
            Console.WriteLine("Обмен значений:");
            Console.WriteLine($"а = {a}, b = {b}");

            a = a + b;
            b = b - a;
            b = -b;
            a = a - b;

            Console.WriteLine("Обмен значений без 3й переменной:");
            Console.WriteLine($"а = {a}, b = {b}");
            Console.WriteLine();

            //Задание 5. Вывод текста по центру консоли

            Console.WriteLine("Введите город проживания");
            string city = Console.ReadLine();

            CenterText(name, surname, city);
        }

        //Метод подсчета расстояния между двумя точками
        static double DistancePoint(double x1, double x2, double y1, double y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }

        //Вывод Имени Фамилии и Города по центру экрана
        static void CenterText(string name, string surname, string city)
        {
            Console.WriteLine(String.Format("{0," + Console.WindowWidth / 2 + "}", name + " " + surname + " Город: " + city));
        }
    }
}
