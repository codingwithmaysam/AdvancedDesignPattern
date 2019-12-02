using System.Xml.Serialization;

namespace SimUDuck_Strategy
{
	internal interface IDuck
	{
		void Display();
		void Swim();
		void PerformQuack();
		void PerformFly();
	}
}