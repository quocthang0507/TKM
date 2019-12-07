using System;

namespace ProxyPattern
{
	class Program
	{
		static void Main(string[] args)
		{
			TheTinDung proxy = new TheTinDung();
			proxy.Request();
			Console.ReadKey();
		}
	}

	/// <summary>
	/// Subject class
	/// </summary>
	abstract class Tien
	{
		public abstract void Request();
	}

	/// <summary>
	/// RealSubject class
	/// </summary>
	class TienMat : Tien
	{
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

		public TheTinDung()
		{
		}

		public override void Request()
		{
			if (realSubject == null)
				realSubject = new TienMat();
			Console.WriteLine("Su dung the tin dung thay the tien mat");
			realSubject.Request();
		}
	}
}
