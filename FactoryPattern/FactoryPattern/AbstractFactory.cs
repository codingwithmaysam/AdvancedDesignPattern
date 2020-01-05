using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
	class AbstractFactory
	{
	}

	public interface IHotDrink
	{
		void Consume();
	}

	internal class Tea : IHotDrink
	{
		public void Consume()
		{
			Console.WriteLine($"This Tea is nice, but I lik eit with milk.");
		}
	}
	internal class Coffee : IHotDrink
	{
		public void Consume()
		{
			Console.WriteLine($"This Coffee is sensational");
		}
	}

	public interface IHotDrinkFactory
	{
		IHotDrink Prepare(int amount);
	}

	internal class TeaFactory : IHotDrinkFactory
	{
		public IHotDrink Prepare(int amount)
		{
			Console.WriteLine($"Put in a tea bag, boil water, pour {amount} ml, add lemon, enjoy!");
			return new Tea();
		}
	}
	internal class CoffeeFactory : IHotDrinkFactory
	{
		public IHotDrink Prepare(int amount)
		{
			Console.WriteLine($"Grind some beans, boild water, pour {amount} ml, add cream, enjoy!");
			return new Coffee();
		}
	}

	public class HotDrinkMachine
	{
		private List<Tuple<string, IHotDrinkFactory>> factories = new List<Tuple<string, IHotDrinkFactory>>();
		public HotDrinkMachine()
		{
			foreach (var t in typeof(DemoAbstractFactory).Assembly.GetTypes())
			{
				if (!t.IsInterface && typeof(IHotDrinkFactory).IsAssignableFrom(t))
					factories.Add(Tuple.Create(t.Name.Replace("Factory", string.Empty), (IHotDrinkFactory)Activator.CreateInstance(t)));
			}
		}
		public IHotDrink MakeDrink()
		{
			Console.WriteLine($"Available Drinks:");
			for (var index = 0; index < factories.Count; index++)
			{
				var touple = factories[index];
				Console.WriteLine($"{index}: {touple.Item1}");
			}

			while (true)
			{
				string s;
				if ((s = Console.ReadLine()) != null
						&& int.TryParse(s, out int i)
						&& i >= 0
						&& i < factories.Count)
				{
					Console.WriteLine("Specify the amount:");
					s = Console.ReadLine();
					if (s != null
							&& int.TryParse(s, out int amount)
							&& amount > 0)
						return factories[i].Item2.Prepare(amount);
				}
			}
		}
	}

	public class DemoAbstractFactory
	{
		static void Main(string[] args)
		{
			var hdm = new HotDrinkMachine();
			var drink = hdm.MakeDrink();
			drink.Consume();
		}
	}
}
