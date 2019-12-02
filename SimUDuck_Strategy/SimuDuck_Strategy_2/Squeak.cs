using System;

namespace SimuDuck_Strategy_2
{
	public class Squeak : IQuackBehavior
	{
		void IQuackBehavior.Quack()
		{
			Console.WriteLine("Squeak!");
		}
	}
}