using System;
using System.Text.RegularExpressions;
using System.Linq;

//Ведров Дмитрий
//Задание 2.

namespace Lesson_52
{
    static class Message
    {
        public static void Q1(string text)
        {
            //Вывести только те слова сообщения,  которые содержат не более n букв. 5 букв
            Console.WriteLine(String.Join(' ', text.Split().Where(x => x.Length <= 5)));
        }
        public static void Q2(string text)
        {
            //Удалить из сообщения все слова, которые заканчиваются на заданный символ. Буква 'е'
            Console.WriteLine(String.Join(' ', text.Split().Where(x => x[x.Length - 1] != 'е')));
        }
        public static void Q3(string text)
        {
            // Найти самое длинное слово сообщения.
            Console.WriteLine(String.Join(' ', text.Split().Where(x => x.Length == text.Split(' ').Max(l => l.Length))));
        }
    }
    class Program
    {        
        static void Main(string[] args)
        {
            string text = "Разработать статический класс Message, содержащий следующие статические методы для обработки текста.";

            Message.Q1(text);
            Message.Q2(text);
            Message.Q3(text);
        }
    }
}
