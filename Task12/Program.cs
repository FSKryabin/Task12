using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task12
{
	public class Program
	{
		public static void Main()
		{
			try
			{
				Console.Write("Введите радиус: ");
				double Radius = Convert.ToDouble(Console.ReadLine());
				if (Radius <= 0)
				{
					Console.Write("Ошибка.");
					return;
				}
				Console.Write("Введите координату Х: ");
				double positionX = Math.Abs(Convert.ToDouble(Console.ReadLine()));
				Console.Write("Введите координату Y: ");
				double positionY = Math.Abs(Convert.ToDouble(Console.ReadLine()));
				Circle.GetСircumference(Radius);
				Circle.GetSquare(Radius);
				Circle.GetPosition(Radius, positionX, positionY);
			}
			catch (FormatException)
			{
				Console.WriteLine("Неверный ввод.");
				return;
			}
		}
	}
}
