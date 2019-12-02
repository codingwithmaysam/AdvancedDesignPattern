#SimUDuck
I implemented strategy Design pattern using C# Delegate instead of using Interface, It reduces the code complexity and makes it easy to underestand.

it also gives us more flexibility in order to apply multiple behaviors related to a specific group of behavior.
```
Example :
public MallardDuck(FlyingBehaviors flyingBehaviors, SoundsBehaviors soundsBehaviors)
		{
			FlyingBehaviors += flyingBehaviors.FlyWithWing;
			QuackBehaviors += soundsBehaviors.Quack;
			QuackBehaviors += soundsBehaviors.Squeak;
		}
```