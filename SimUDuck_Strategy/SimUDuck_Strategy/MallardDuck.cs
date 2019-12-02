using System;

namespace SimUDuck_Strategy
{
	internal class MallardDuck : Duck
	{
		public new void Display()
		{
			Console.WriteLine("This is a MallardDuck");
		}
		public MallardDuck()
		{
			FlyingBehaviors += new FlyingBehaviors().FlyWithWing;
			QuackBehaviors += new SoundsBehaviors().Quack;
			QuackBehaviors += new SoundsBehaviors().Squeak;
		}
	}
}