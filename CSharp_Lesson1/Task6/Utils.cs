using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
	//Создать класс с методами, которые могут пригодиться в вашей учебе (Print, Pause).
	class Utils
	{
		static void Pause()
		{
			Console.ReadKey();
		}		static void Print(string ms, int x, int y)
		{
			Console.SetCursorPosition(x, y);
			Console.WriteLine(ms);
		}
		static void Main(string[] args)
		{
		}
	}
}
