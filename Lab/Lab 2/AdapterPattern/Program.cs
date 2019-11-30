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
			Steam target = new Boil();
			target.State();
			Console.ReadKey();
		}
	}

	class Boil : Steam
	{
		private Water water = new Water();

		public override void State()
		{
			water.State();
			Console.WriteLine("is converted to");
			base.State();
		}
	}

	class Water
	{
		int degreeCelcius;
		double volume; //liter

		public int DegreeCelcius { get { return degreeCelcius; } }
		public double Volume { get { return volume; } }

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

		public void State()
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

		public virtual void State()
		{
			Console.WriteLine("Steam volume {0} at {1} degree Celcius", volume, degreeCelcius);
		}
	}
}
