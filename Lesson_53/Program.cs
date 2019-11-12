using System;
using System.Linq;

// Ведров Дмитрий
// Задание 3.

namespace Lesson_53
{    
    class Program
    {
        static void Main(string[] args)
        {
            Method("abcd", "badc");
        }
        public static void Method(string a, string b)
        {
            var aStr = a.Select(Char.ToLower).OrderBy(x => x);
            var bStr = b.Select(Char.ToLower).OrderBy(x => x);

            Console.WriteLine(aStr.SequenceEqual(bStr));
        }
    }
}
