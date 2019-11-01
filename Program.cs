using System;

namespace Lesson_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ведров Дмитрий
        }
        // Задание 1
        static void MinInTree()
        {
            Console.WriteLine("Введите первое число:");
            double x1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число:");
            double x2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите третье число:");
            double x3 = double.Parse(Console.ReadLine());

            if (x1 < x2)
            {
                if (x1 < x3)
                {
                    Console.WriteLine($"Первое число {x1} является самым маленьким");
                }
                else if (x2 < x3)
                {
                    Console.WriteLine($"Второе число {x2} является самым маленьким");
                }
                else
                {
                    Console.WriteLine($"Третье число {x3} является самым маленьким");
                }
            }
            else if (x2 < x3)
            {
                Console.WriteLine($"Второе число {x2} является самым маленьким");
            }
            else
            {
                Console.WriteLine($"Третье число {x3} является самым маленьким");
            }
        }
        // Задание 2
        static void CountNumbers()
        {
            Console.WriteLine("Введите число:");
            string number = Console.ReadLine();
            int count = 0;
            /*
            for (int i = 0; i < number.Length; i++)
            {
                count++;
            }
            
            while (count < number.Length)
            {
                count++;
            }
            */
            foreach (char c in number)
            {
                count++;
            }

            Console.WriteLine($"Длина числа равна {count}");                       
        }
        // Задание 3
        static void SumNumbers()
        {
            int[] nums = new int[10];
            int num;
            int summ = 0;
            
            Console.WriteLine("Введите десять положительных или отрицательных целых числел, либо введите 0");

            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine("Введите число:");
                num = int.Parse(Console.ReadLine());
                if (num != 0)
                {
                    nums[i] = num;
                }
                else
                {
                    break;
                }                               
            }

            for (int j = 0; j < nums.Length; j++)
            {
                if (nums[j] % 2 != 0 && nums[j] > 0)
                {
                    summ += nums[j];
                }
            }

            Console.WriteLine($"Сумма нечетных положительных чисел равна {summ}");
        }
        // Задание 4
        static void LoginPasword()
        {
            Console.WriteLine("Авторизация по логину и паролю.");
            int count = 3;
            string login, passwd;

            do
            {
                Console.Write("Введите логин: ");
                login = Console.ReadLine();
                
            } while (login != "root");            

            for (int i = 1; i <= count; i++)
            {
                Console.Write("Введите пароль: ");
                passwd = Console.ReadLine();

                if (passwd == "GeekBrains")
                {
                    Console.WriteLine("Добро пожаловать!");
                    break;
                }               
                Console.WriteLine($"Неверный пароль, попробуйте еще раз.\nОстальсо попыток: {count - i}");
                Console.Write("Введите пароль: ");
            }

        }
        // Задание 5
        static void IndexMass()
        {
            Console.WriteLine("Расчет индекса массы тела.");
            Console.Write("Введите свой рост в см: ");
            double weight = double.Parse(Console.ReadLine());
            Console.Write("Введите свой вес в кг: ");
            double mass = double.Parse(Console.ReadLine());

            double imt = mass / Math.Pow((weight / 100), 2);
            Console.WriteLine($"Ваш индекс массы тела равен {Math.Round(imt, 2)}");

            if (imt <= 16)
            {
                Console.WriteLine("Выраженный дефицит массы тела");
            }
            else if (imt > 16 && imt <= 18.5)
            {
                Console.WriteLine("Недостаточноя масса тела");
            }
            else if (imt > 18.5 && imt <= 25)
            {
                Console.WriteLine("Норма");
            }
            else if (imt > 25 && imt <= 30)
            {
                Console.WriteLine("Избыточная масса тела");
            }
            else if (imt > 30 && imt <= 35)
            {
                Console.WriteLine("Ожирение первой степени");
            }
            else if (imt > 35 && imt <= 40)
            {
                Console.WriteLine("Ожирение второй степени");
            }
            else if (imt > 40)
            {
                Console.WriteLine("Всё очень плохо");
            }
        }
        // Задание 6
        static void GoodNumbers()
        {
            
            DateTime start = DateTime.Now;
            int minCount = 1;
            int maxCount = 1000000000;
            int count = 0;
            int number;
            int ch;

            for (int i = minCount; i <= maxCount; i++)
            {
                number = i;
                ch = 0;
                
                while (number != 0)
                {
                    ch += number % 10;
                    number /= 10;
                }
                if (i % ch == 0)
                {
                    count++;
                }
            }
            DateTime finish = DateTime.Now;
            Console.WriteLine($"Количество хороших чисел равно {count}");
            Console.WriteLine($"Время затраченное на подсчет равно {finish-start}");
        } 
    }
}
