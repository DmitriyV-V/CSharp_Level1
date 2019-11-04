using System;

namespace Lesson_3._2
{
    class Program
    {
        static string console_message = "Введите число:";
        static int GetValue(string message)
        {            
            string num;
            int sum = 0;
            int x;
            bool number;

            do
            {
                Console.WriteLine(console_message);
                num = Console.ReadLine();
                number = int.TryParse(num, out x);
                
                if (number && int.Parse(num) > 0 && int.Parse(num) % 2 == 1)
                    {
                        sum += int.Parse(num);
                    }
                
            } while (!number || int.Parse(num) != 0);
            
            Console.WriteLine(sum);
            return sum;
        }
        static void Main(string[] args)
        {
            GetValue(console_message);
        }
    }
}
