using System;

namespace FactoryMethod
{
	class Program
	{
		static void Main(string[] args)
		{
			NhaMay[] CacNhaMay = new NhaMay[2];
			CacNhaMay[0] = new NhaMay1("Nha may Da Lat", "So 1 Phu Dong Thien Vuong, Da Lat, Lam Dong", "0263-113-114");
			CacNhaMay[1] = new NhaMay2("Nha may Ben Tre", "So 1 Dong Khoi, Ben Tre", "0243-221-223");
			foreach (NhaMay nhaMay in CacNhaMay)
			{
				BanhKeo banhKeo = nhaMay.SanXuat();
				Console.WriteLine(nhaMay.ToString());
			}
			Console.ReadKey();
		}
	}
}
