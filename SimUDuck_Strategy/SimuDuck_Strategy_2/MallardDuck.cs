using System;

namespace SimuDuck_Strategy_2
{
	public class MallardDuck : Duck
	{
		public MallardDuck() :base(new FlyWithWing(), new Quack())
		{
		}
		public new void Display()
		{
			Console.WriteLine("This is a Mallard Duck!");
		}

	}
}