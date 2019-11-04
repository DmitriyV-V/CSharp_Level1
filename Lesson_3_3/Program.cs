using System;

namespace Lesson_3_3
{
    class Fraction
    {
        int nominator;
        int denominator;

        public int Nominator
        {
            get { return nominator; }
            set { nominator = value; }
        }
        public int Denominator
        {
            get { return denominator; }
            set
            {
                if (value == 0)
                {
                    throw new ArgumentException("Знаменатель не может быть равен 0");
                }
                else
                {
                    denominator = value;
                }
            }
        }
        public double Decimal
        {
            get { return (double)nominator / (double)denominator; }
        }

        public Fraction Plus(Fraction x2)
        {
            Fraction x3 = new Fraction();
            if (this.denominator == x2.denominator)
            {
                x3.nominator = this.nominator + x2.nominator;
                x3.denominator = this.denominator;
            }
            else
            {
                x3.nominator = this.nominator * x2.denominator + x2.nominator * this.denominator;
                x3.denominator = this.denominator * x2.denominator;
            }
            return x3;
        }
        public Fraction Minus(Fraction x2)
        {
            Fraction x3 = new Fraction();
            if (this.denominator == x2.denominator)
            {
                x3.nominator = this.nominator - x2.nominator;
                x3.denominator = this.denominator;
            }
            else
            {
                x3.nominator = this.nominator * x2.denominator - x2.nominator * this.denominator;
                x3.denominator = this.denominator * x2.denominator;
            }
            return x3;
        }
        public Fraction Multi(Fraction x2)
        {
            Fraction x3 = new Fraction();
            x3.nominator = this.nominator * x2.nominator;
            x3.denominator = this.denominator * x2.denominator;
            return x3;
        }
        public Fraction Division(Fraction x2)
        {
            Fraction x3 = new Fraction();
            x3.nominator = this.nominator * x2.denominator;
            x3.denominator = this.denominator * x2.nominator;
            return x3;
        }
        public string ToString()
        {
            return nominator + "/" + denominator;
        }
        public string SimpleFraction()
        {
            if (nominator > denominator)
            {
                int ch = nominator / denominator;
                int ost = nominator % denominator;
                return ch + " " + ost + "/" + denominator;
            }
            return nominator + "/" + denominator;
        }
    }
    class Program
    {        
        static void Main(string[] args)
        {
            Fraction fraction1 = new Fraction();
            Console.WriteLine("Введите числитель дроби №1:");
            fraction1.Nominator = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите знаменатель дроби №1:");
            fraction1.Denominator = int.Parse(Console.ReadLine());

            Fraction fraction2 = new Fraction();
            Console.WriteLine("Введите числитель дроби №2:");
            fraction2.Nominator = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите знаменатель дроби №2:");
            fraction2.Denominator = int.Parse(Console.ReadLine());

            Console.WriteLine($"Дробь №1: {fraction1.ToString()}. В десятичной форме: {fraction1.Decimal}");
            Console.WriteLine($"Дробь №2: {fraction2.ToString()}. В десятичной форме: {fraction2.Decimal}");
            Console.WriteLine($"Сложение дробей: {fraction1.ToString()} + {fraction2.ToString()}");
            Fraction plus = fraction1.Plus(fraction2);
            Console.WriteLine($"{plus.ToString()}, сокращенная дробь {plus.SimpleFraction()}");
            Console.WriteLine($"Вычитание дробей: {fraction1.ToString()} - {fraction2.ToString()}");
            Fraction minus = fraction1.Minus(fraction2);
            Console.WriteLine($"{minus.ToString()}, сокращенная дробь {minus.SimpleFraction()}");
            Console.WriteLine($"Умножение дробей: {fraction1.ToString()} * {fraction2.ToString()}");
            Fraction multi = fraction1.Multi(fraction2);
            Console.WriteLine($"{multi.ToString()}, сокращенная дробь {multi.SimpleFraction()}");
            Console.WriteLine($"Деление дробей: {fraction1.ToString()} : {fraction2.ToString()}");
            Fraction division = fraction1.Division(fraction2);
            Console.WriteLine($"{division.ToString()}, сокращенная дробь {division.SimpleFraction()}");
        }
    }    
}
