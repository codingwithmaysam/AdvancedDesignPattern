#SimUDuck
I implemented strategy Design pattern using C# Delegate instead of using Interface, It reduced the code complexity and make it more easy to underestand.

it also gives us more flexibility in order to apply multiple behaviors related to a specific group of behaviors.
```
Example :
public MallardDuck()
		{
			QuackBehaviors += new SoundsBehaviors().Quack; 
			QuackBehaviors += new SoundsBehaviors().Squeak;
			QuackBehaviors += new SoundsBehaviors().NoSound;
		}
```