using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Task3
{
    class CoolArray
    {
        private int[] a;
        Random rnd = new Random();

        public CoolArray(int n)
        {
            a = new int[n];
            for (int i = 0; i < n; i++)
                a[i] = rnd.Next(1, 101);
        }

        public CoolArray(string filename)
        {
            //Если файл существует
            if (File.Exists(filename))
            {
                //Считываем все строки в файл 
                string[] ss = File.ReadAllLines(filename);
                a = new int[ss.Length];
                //Переводим данные из строкового формата в числовой
                for (int i = 0; i < ss.Length; i++)
                    a[i] = int.Parse(ss[i]);
            }
            else Console.WriteLine("Error load file");
        }

        public CoolArray(int size, int start, int step)
        {
            a = new int[size];
            int cur = start;
            for (int i = 0; i < size; i++)
            {
                a[i] = cur;
                cur += step;
            }
        }

        public CoolArray(int[] arr)
        {
            a = arr;
        }

        public int Max
        {
            get
            {
                return a.Max();
            }
        }

        public int this[int i]
        {
            get { return a[i]; }
            set { a[i] = value; }
        }

        public void Print()
        {
            foreach (int el in a)
                Console.Write("{0,4}", el);
            Console.WriteLine();
        }

        public int Sum
        {
            get
            {
                int sum = 0;
                for (int i = 0; i < a.Length; i++)
                {
                    sum += a[i];
                }
                return sum;
            }
        }

        public CoolArray Inverse()
        {
            int[] a_new = new int[a.Length];
            for (int i = 0; i < a.Length; i++)
            {
                a_new[i] = -a[i];
            }
            return new CoolArray(a_new);
        }

        public CoolArray Multi(int mul)
        {
            int[] a_new = new int[a.Length];
            for (int i = 0; i < a.Length; i++)
            {
                a_new[i] = a[i] * mul;
            }
            return new CoolArray(a_new);
        }

        public int MaxCount()
        {
            int cnt = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == a.Max()) cnt++;
            }
            return cnt;
        }

        public Dictionary<int, int> getFrequency()
        {
            Dictionary<int, int> freq = new Dictionary<int, int>();
            for (int i=0; i<a.Length; i++)
            {
                if (freq.ContainsKey(a[i])) freq[a[i]]++;
                else freq[a[i]] = 1;
            }
            return freq;
        }
    }
}
