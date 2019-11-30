using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
	class Program
	{
		static void Main(string[] args)
		{
			Steam target = new Adapter();
			target.Request();
			Console.ReadKey();
		}
	}

	class Adapter : Steam
	{
		private Water _adaptee = new Water();

		public override void Request()
		{
			_adaptee.SpecificRequest();
		}
	}

	class Water
	{
		int degreeCelcius;
		double volume; //liter

		public Water()
		{
			degreeCelcius = 20;
			volume = 1; //liter
		}

		public Water(int degreeCelcius, double volume)
		{
			this.degreeCelcius = degreeCelcius;
			this.volume = volume;
		}

		public void SpecificRequest()
		{
			Console.WriteLine("Water volume {0} at {1} degree Celcius", volume, degreeCelcius);
		}
	}

	class Steam
	{
		int degreeCelcius;
		double volume;

		public int DegreeCelcius { get { return degreeCelcius; } }
		public double Volume { get { return volume; } }

		public Steam()
		{
			degreeCelcius = 100;
			volume = 1700; //Ratio 1700:1 at 100 degree celcius
		}

		public Steam(int degreeCelcius, double volume)
		{
			this.degreeCelcius = degreeCelcius;
			this.volume = volume;
		}

		public virtual void Request()
		{
			Console.WriteLine("Steam volume {0} at {1} degree Celcius", volume, degreeCelcius);
		}
	}
}
