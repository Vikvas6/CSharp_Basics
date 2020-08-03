using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Lesson3
{
    class Task2
    {
        // С клавиатуры вводятся числа, пока не будет введён 0 (каждое число в новой строке).
        // Требуется подсчитать сумму всех нечётных положительных чисел. Сами числа и сумму вывести на экран, используя tryParse.
        // Вашченков Виктор
        static void Main(string[] args)
        {
            int sum = 0;
            List<int> numbers = new List<int>();

            string input = Console.ReadLine();
            while (input != "0")
            {
                bool parsed = int.TryParse(input, out int num);
                if (parsed)
                {
                    if (num > 0 && num % 2 == 1)
                    {
                        sum += num;
                        numbers.Add(num);
                    }
                }
                else
                {
                    Console.WriteLine("Введённое значение не может быть приведено к числу, попробуйте ещё раз.");
                }
                input = Console.ReadLine();
            }

            string res = "";
            if (numbers.Count > 0)
            {
                foreach (int i in numbers)
                {
                    res += $"{i} + ";
                }
                res = res.Substring(0, res.Length - 2) + $" = {sum}";
                Console.WriteLine(res);
            }
            else
            {
                Console.WriteLine("Не было введено ни одного положительного нечётного числа, сумма равна нулю.");
            }
            Console.ReadKey();
        }
    }
}
