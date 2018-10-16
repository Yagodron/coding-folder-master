using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constant
{
	class Program
	{
		static void Main(string[] args) {
			// На 13-й строке, создаем константу с именем pi, типа double и присваиваем ей значение 3.141

			const double pi = 3.141;

			// На 17-й строке, выводим значение константы - pi, на экран.

			Console.WriteLine(pi);

			// Попытка присвоения константе нового значения, приводит к ошибке уровня компиляции!

			//pi = 2.71828183; 

			// Задержка.
			Console.ReadKey();
		}
	}
}
