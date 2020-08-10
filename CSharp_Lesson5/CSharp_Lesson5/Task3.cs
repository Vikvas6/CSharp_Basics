using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp_Lesson5
{
    class Task3
    {
        //*Для двух строк написать метод, определяющий, является ли одна строка перестановкой другой.
        //Например: badc являются перестановкой abcd.
        //Вашченков Виктор
        private static Dictionary<Char, int> GetCharDict(string s)
        {
            //s = s.ToLower();

            Dictionary<Char, int> result = new Dictionary<char, int>();

            foreach (Char ch in s)
            {
                if (result.ContainsKey(ch)) result[ch]++;
                else result[ch] = 1;
            }

            return result;
        }

        /// <summary>
        /// Проверяет входит ли множество ключей словаря А в множество ключей словаря В
        /// </summary>
        /// <param name="a">Меньший словарь, будет проверено входит ли он в больший</param>
        /// <param name="b">Больший словарь, будет проверено входит ли меньший в него</param>
        /// <returns></returns>
        private static bool IsInclude(Dictionary<char, int> a, Dictionary<char, int> b)
        {
            foreach (var key in a.Keys)
            {
                if (!b.ContainsKey(key)) return false;
            }
            return true;
        }


        private static bool CompareDicts(Dictionary<char, int> a, Dictionary<char, int> b)
        {
            if (!IsInclude(a, b)) return false;
            if (!IsInclude(b, a)) return true;

            foreach(var key in a.Keys)
            {
                if (a[key] != b[key]) return false;
            }
            return true;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первую строку");
            var s1 = Console.ReadLine();
            Console.WriteLine("Введите вторую строку");
            var s2 = Console.ReadLine();

            if (CompareDicts(GetCharDict(s1), GetCharDict(s2))) Console.WriteLine("Вторая строка является перестановкой первой");
            else Console.WriteLine("Вторая строка не является перестановкой первой");

            Console.ReadKey();
        }
    }
}
