using System;

namespace ProxyPattern
{
	class Program
	{
		static void Main(string[] args)
		{
			TheTinDung proxy = new TheTinDung(1000000);
			proxy.Request();
			Console.ReadKey();
		}
	}

	/// <summary>
	/// Subject class
	/// </summary>
	abstract class Tien
	{
		public double amount { get; set; }

		public Tien(double amount)
		{
			this.amount = amount;
		}

		public abstract void Request();
	}

	/// <summary>
	/// RealSubject class
	/// </summary>
	class TienMat : Tien
	{
		public TienMat(double amount) : base(amount)
		{

		}

		public override void Request()
		{
			Console.WriteLine("Da thanh toan thanh cong");
		}
	}

	/// <summary>
	/// Proxy class
	/// </summary>
	class TheTinDung : Tien
	{
		private TienMat realSubject;

		public TheTinDung(double amount) : base(amount)
		{
			this.realSubject = new TienMat(amount);
		}

		public override void Request()
		{
			Console.WriteLine("Su dung The tin dung thay the Tien mat");
			Console.WriteLine("Tai khoan ben trong the la : " + realSubject.amount);
			Console.WriteLine("Tuong ung voi so tien mat la : " + realSubject.amount);
			realSubject.Request();
		}
	}
}
