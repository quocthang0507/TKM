using System;

namespace AdapterPattern
{
	class Program
	{
		static void Main(string[] args)
		{
			// Steam target = new Boil(100, 3.75);
			Steam target = new Boil();
			target.State();
			Console.ReadKey();
		}
	}

	/// <summary>
	/// Adapter class: Quá trình đun sôi nước, nước chuyển từ dạng lỏng sang dạng khí
	/// </summary>
	class Boil : Steam
	{
		private Water water;

		public Boil()
		{
			water = new Water();
		}

		public Boil(int degreeCelcius, double waterVolume) : base(degreeCelcius, waterVolume)
		{
			water = new Water(waterVolume);
		}

		/// <summary>
		/// Trạng thái của nước khi đun sôi
		/// </summary>
		public override void State()
		{
			water.State();
			Console.WriteLine("is converted to");
			base.State();
		}
	}

	/// <summary>
	/// Adaptee class: Nước
	/// </summary>
	class Water
	{
		int degreeCelcius;
		double volume; //liter

		/// <summary>
		/// Nhiệt độ của nước
		/// </summary>
		public int DegreeCelcius { get { return degreeCelcius; } }

		/// <summary>
		/// Thể tích của nước
		/// </summary>
		public double Volume { get { return volume; } }

		public Water()
		{
			degreeCelcius = 20;
			volume = 1; //liter
		}

		public Water(double volume)
		{
			degreeCelcius = 20;
			this.volume = volume;
		}

		public Water(int degreeCelcius, double volume)
		{
			this.degreeCelcius = degreeCelcius;
			this.volume = volume;
		}

		/// <summary>
		/// Trạng thái của nước
		/// </summary>
		public void State()
		{
			Console.WriteLine("Water volume {0} liter(s) at {1} degree Celcius", volume, degreeCelcius);
		}
	}

	/// <summary>
	/// Target class: Hơi nước
	/// </summary>
	class Steam
	{
		int degreeCelcius;
		double volume;

		/// <summary>
		/// Nhiệt độ của hơi nước
		/// </summary>
		public int DegreeCelcius { get { return degreeCelcius; } }

		/// <summary>
		/// Thể tích của hơi nước
		/// </summary>
		public double Volume { get { return volume; } }

		public Steam()
		{
			degreeCelcius = 100;
			volume = 1700; //Ratio 1700:1 at 100 degree celcius
		}

		public Steam(int degreeCelcius, double waterVolume)
		{
			this.degreeCelcius = degreeCelcius;
			this.volume = waterVolume * 1700;
		}

		/// <summary>
		/// Trạng thái của hơi nước
		/// </summary>
		public virtual void State()
		{
			Console.WriteLine("Steam volume {0} liter(s) at {1} degree Celcius", volume, degreeCelcius);
		}
	}
}
