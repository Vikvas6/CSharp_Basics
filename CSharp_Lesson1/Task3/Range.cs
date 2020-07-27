using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
	/*а) Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2 по формуле r=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2). Вывести результат, используя спецификатор формата .2f (с двумя знаками после запятой);
	  б) *Выполнить предыдущее задание, оформив вычисления расстояния между точками в виде метода.*/
	class Range
	{
		static double range(double x1, double x2, double y1, double y2)
		{
			return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
		}
		static void Main(string[] args)
		{
			Console.Write("x1 = ");
			var x1 = Convert.ToDouble(Console.ReadLine());
			Console.Write("y1 = ");
			var y1 = Convert.ToDouble(Console.ReadLine());
			Console.Write("x2 = ");
			var x2 = Convert.ToDouble(Console.ReadLine());
			Console.Write("y2 = ");
			var y2 = Convert.ToDouble(Console.ReadLine());

			Console.WriteLine("{0:f2}", range(x1,x2,y1,y2));
			Console.ReadKey();
		}
	}
}
