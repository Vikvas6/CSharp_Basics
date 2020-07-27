using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
	/*а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
	  б) *Сделать задание, только вывод организовать в центре экрана.
	  в) **Сделать задание б с использованием собственных методов (например, Print(string ms, int x,int y).*/
{
	class PrintFIC
	{
		static void Print(string ms, int x, int y)
		{
			Console.SetCursorPosition(x, y);
			Console.WriteLine(ms);
		}
		static void Main(string[] args)
		{
			var name = "Виктор";
			var surname = "Вашченков";
			var city = "Санкт-Петербург";
			var msg = $"{surname} {name}, г. {city}";

			Console.WriteLine(msg);

			Console.SetCursorPosition(Console.WindowWidth / 4, Console.WindowHeight / 4);
			Console.WriteLine(msg);

			Print(msg, Console.WindowWidth / 2, Console.WindowHeight / 2);

			Console.ReadKey();
		}
	}
}
