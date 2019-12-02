using System;

namespace SimUDuck_Strategy
{
	public class Duck : IDuck
	{
		public Action FlyingBehaviors;
		public Action QuackBehaviors;
		public Action SwimBehaviors;

		public void Display()
		{
			throw new NotImplementedException();
		}

		public void Swim()
		{
			SwimBehaviors.Invoke();
		}

		public void PerformQuack()
		{
			QuackBehaviors.Invoke();
		}

		public void PerformFly()
		{
			FlyingBehaviors.Invoke();
		}
	}
}