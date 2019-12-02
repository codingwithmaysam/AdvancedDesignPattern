using System;

namespace SimuDuck_Strategy_2
{
	public class FlyWithWing : IFlyBehavior
	{
		public void Fly()
		{
			Console.WriteLine("I`m Flying with my wings...");
		}
	}
}