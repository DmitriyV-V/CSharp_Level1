using System;
using System.Text.RegularExpressions;

        // Ведров Дмитрий
        //Задание 1. а, б.

namespace Lesson_51
{
    class Program
    {
        // Проверка логина без регулярных выражений
        static void LoginAcess()
        {
            Console.WriteLine("Проверка логина без регулярного выражения");
            Console.Write("Введите логин: ");
            string login = Console.ReadLine();
            bool correctLog = true;

            if (login.Length > 1 && login.Length < 10)
            {
                if (!Char.IsDigit(login[0]))
                {
                    for (int i = 0; i < login.Length; i++)
                    {
                        if (!Char.IsLetterOrDigit(login[i]))
                        {
                            Console.WriteLine("Некорректные символы в логине");
                            correctLog = false;
                            break;
                        }
                    }
                    if (correctLog)
                    {
                        Console.WriteLine("Логин введен корректно!");
                    }
                    else
                    {
                        Console.WriteLine("Логин введен некорректно");
                    }
                }
                else
                {
                    Console.WriteLine("Логин не может начинаться на цифру");
                }
            }
            else
            {
                Console.WriteLine("Некорректная длина логина");
            }
        }

        // Проверка логина с помощью регулярных выражений
        static void RegLoginAcess()
        {
            string regular = @"^[a-zA-Z][a-zA-Z0-9]{1,9}$";
            Regex regex = new Regex(regular);
            
            Console.WriteLine("Проверка логина регулярным выражением");
            Console.Write("Введите логин: ");
            string login = Console.ReadLine();
            if (regex.Match(login).Success)
            {
                Console.WriteLine("Логин введен корректно!");
            }
            else
            {
                Console.WriteLine("Логин введен некорректно");
            }



        }

        static void Main(string[] args)
        {
            RegLoginAcess();
            Console.WriteLine();
            LoginAcess();
        }
    }
}
