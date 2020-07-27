using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
	/*Написать программу обмена значениями двух переменных:
		а) с использованием третьей переменной;
		б) *без использования третьей переменной.*/
	class Swap
	{
		static void Main(string[] args)
		{
			//используя 3 переменные
			var a = 1;
			var b = 2;
			var t = a;
			a = b;
			b = t;

			//используя 2 переменные (но только для чисел и не учитывая, что может быть переполнение при сложении)
			var c = 1;
			var d = 2;
			c = c + d;
			d = c - d;
			c = c - d;
		}
	}
}
