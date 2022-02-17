using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task12
{
	static class Circle
	{
		public static void GetСircumference(double Radius)
		{
			double Сircumference = Math.PI * 2 * Radius;
			Console.WriteLine("Длина окружности {0:f2}", Сircumference);
		}
		public static void GetSquare(double Radius)
		{
			double Square = Math.PI * Math.Pow(Radius, 2.0);
			Console.WriteLine("Площадь круга {0:f2}", Square);
		}
		public static void GetPosition(double Radius, double positionX, double positionY)
		{
			if (positionX <= Radius && positionY <= Radius)
			{
				Console.WriteLine("Точка с координатами x = {0}, y = {1} принадлежит кругу с радиусом {2}", positionX, positionY, Radius);
			}
			else
			{
				Console.WriteLine("Точка с координатами x = {0}, y = {1} не принадлежит кругу с радиусом {2}", positionX, positionY, Radius);
			}
		}
	}
}
