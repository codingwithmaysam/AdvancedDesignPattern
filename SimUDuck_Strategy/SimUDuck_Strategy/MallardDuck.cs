using System;

namespace SimUDuck_Strategy
{
	internal class MallardDuck : Duck
	{
		public new void Display()
		{
			Console.WriteLine("This is a MallardDuck");
		}
		public MallardDuck(FlyingBehaviors flyingBehaviors, SoundsBehaviors soundsBehaviors)
		{
			FlyingBehaviors += flyingBehaviors.FlyWithWing;
			QuackBehaviors += soundsBehaviors.Quack;
			QuackBehaviors += soundsBehaviors.Squeak;
		}
	}
}