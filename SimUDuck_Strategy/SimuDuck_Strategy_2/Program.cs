using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuDuck_Strategy_2
{
	class Program
	{
		static void Main(string[] args)
		{
			var duck1 = new MallardDuck();
			duck1.Display();
			duck1.PerformFly();
			duck1.MakeSound();
		}
	}
}
