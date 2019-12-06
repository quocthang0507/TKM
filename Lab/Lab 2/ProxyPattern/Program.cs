using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

	abstract class Tien
	{
		public abstract void Request();
	}

	class TienMat : Tien
	{
		public override void Request()
		{
			Console.WriteLine("Da thanh toan thanh cong");
		}
	}

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
