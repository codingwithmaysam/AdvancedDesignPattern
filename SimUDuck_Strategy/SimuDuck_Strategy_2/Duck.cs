using System;

namespace SimuDuck_Strategy_2
{
	public abstract class Duck
	{
		private IFlyBehavior _flyBehavior;
		private IQuackBehavior _quackBehavior;

		protected Duck(IFlyBehavior flyBehavior, IQuackBehavior quackBehavior)
		{
			_flyBehavior = flyBehavior;
			_quackBehavior = quackBehavior;
		}
		public void Display()
		{
			throw new NotImplementedException();
		}

		public void MakeSound()
		{
			_quackBehavior.Quack();
		}

		public void PerformFly()
		{
			_flyBehavior.Fly();
		}
	}
}