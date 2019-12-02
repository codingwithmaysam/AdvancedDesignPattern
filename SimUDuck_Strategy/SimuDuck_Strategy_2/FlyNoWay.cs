using System;

namespace SimuDuck_Strategy_2
{
	public class FlyNoWay : IFlyBehavior
	{
		public void Fly()
		{
			Console.WriteLine("I can't Fly :(");
		}
	}
}