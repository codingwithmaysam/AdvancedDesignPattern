using System;

namespace SimuDuck_Strategy_2
{
	public class Quack : IQuackBehavior {
		void IQuackBehavior.Quack()
		{
			Console.WriteLine("Quack!");
		}
	}
}