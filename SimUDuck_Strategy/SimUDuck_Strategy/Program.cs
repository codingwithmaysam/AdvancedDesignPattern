using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimUDuck_Strategy
{
	class Program
	{
		static void Main(string[] args)
		{
			var mallardDuck = new MallardDuck(new FlyingBehaviors(), new SoundsBehaviors());
			mallardDuck.Display();
			mallardDuck.PerformQuack();
		}
	}
}
