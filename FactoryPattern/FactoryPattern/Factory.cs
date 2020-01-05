using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace FactoryPattern
{
	class Factory
	{
	}

	public class Point
	{
		private double x, y;

		private Point(double x, double y)
		{
			this.x = x;
			this.y = y;
		}

		public override string ToString()
		{
			return $"{nameof(x)}: {x}, {nameof(y)}: {y}";
		}
		public static class Factory
		{
			public static Point CartesianPoint(double x, double y)
			{
				return new Point(x, y);
			}

			public static Point PolarPoint(double rho, double theta)
			{
				return new Point(rho * Math.Sin(theta), rho * Math.Cos(theta));
			}

		}
	}



	public class Demo
	{
		static void Main(string[] args)
		{
			var p = Point.Factory.CartesianPoint(1.0, Math.PI / 2);
			Console.WriteLine(p);
		}
	}
}
