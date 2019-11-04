using System;

namespace Lesson_3_1_2
{
    class Complex
    {
        // Все методы и поля публичные. Мы можем получить доступ к ним из другого класса.
        public double im;
        public double re;

        public Complex Plus(Complex x2)
        {
            Complex x3 = new Complex();
            x3.im = x2.im + this.im;
            x3.re = x2.re + this.re;
            return x3;
        }
        //Метод вычитания комплексных чисел
        public Complex Minus(Complex x2)
        {
            Complex x3 = new Complex();
            x3.im = this.im - x2.im;
            x3.re = this.re - x2.re;
            return x3;
        }
        //Метод умножения комплексных чисел
        public Complex Multi(Complex x2)
        {
            Complex x3 = new Complex();
            x3.im = this.re * x2.im + this.im * x2.re;
            x3.re = re * this.re - this.im * x2.im;
            return x3;
        }
        public string ToString()
        {
            return re + "+" + im + "i";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Complex complex1 = new Complex();
            complex1.re = 3;
            complex1.im = 15;

            Complex complex2 = new Complex();
            complex2.re = 2;
            complex2.im = 3;

            Console.WriteLine($"Число 1: {complex1.ToString()}");
            Console.WriteLine($"Число 2: {complex2.ToString()}");

            Console.WriteLine("Введите номер операции над комплексными числами");
            Console.WriteLine("1. Сложение\n2. Вычитание\n3. Умножение");

            int answer = int.Parse(Console.ReadLine());
            switch (answer)
            {
                case 1:
                    Complex result = complex1.Plus(complex2);
                    Console.WriteLine(result.ToString());
                    break;
                case 2:
                    //Вызов метода вычитания комплексных чисел
                    Complex minus = complex1.Minus(complex2);
                    Console.WriteLine(minus.ToString());
                    break;
                case 3:
                    //Вызов метода умножения комплексных чисел
                    Complex multi = complex1.Multi(complex2);
                    Console.WriteLine(multi.ToString());
                    break;
                default:
                    Console.WriteLine("Данного номера операции нет");
                    break;
            }            
        }
    }
}
