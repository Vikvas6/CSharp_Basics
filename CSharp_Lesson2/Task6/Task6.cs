using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    class Task6
    {
        //*Написать программу подсчета количества «хороших» чисел в диапазоне от 1 до 1 000 000 000.
        //«Хорошим» называется число, которое делится на сумму своих цифр.
        //Реализовать подсчёт времени выполнения программы, используя структуру DateTime.
        //Вашченков Виктор
        static bool IsGood(int number)
        {
            int sum = 0;
            int cur_num = number;
            while (cur_num != 0)
            {
                sum += cur_num % 10;                
                cur_num = cur_num / 10;
            }
            return number % sum == 0;
        }
        static void Main(string[] args)
        {
            DateTime start_date = DateTime.Now;

            int cnt = 0;
            for (int i=1; i<=1000000000; i++)
            {
                if (IsGood(i)) cnt++;
            }

            Console.WriteLine($"Хороших чисел {cnt} найдено за {DateTime.Now - start_date}");
            Console.ReadKey();

            //Хороших чисел 61574510 найдено за 00:02:15.4247458

        }
    }
}
