using System;
using System.Collections.Generic;

namespace Decorator
{
	class Program
	{
		static void Main()
		{
			//Thuc don trong ngay hom nay
			CanhChua canhChua = new CanhChua("Ca loc tuoi", "Qua thom vang", "Ca chua Da Lat", "Me chua");
			canhChua.HienThi();
			Available TrangThai_CanhChua = new Available(canhChua, 10);

			CaKhoTo caKho = new CaKhoTo("Ca loc tuoi", "Nuoc mam Phu Quoc", "Ot sung tuoi", "Hanh la Da Lat");
			caKho.HienThi();
			Available TrangThai_CaKho = new Available(caKho, 10);

			//Dat mon an
			TrangThai_CaKho.OrderItem("La Quoc Thang");
			TrangThai_CanhChua.OrderItem("La Quoc Thang");
			TrangThai_CaKho.OrderItem("Gordon Ramsay");
			TrangThai_CanhChua.OrderItem("Christine Ha");

			//Con lai
			TrangThai_CaKho.HienThi();
			TrangThai_CanhChua.HienThi();
			Console.ReadKey();
		}
	}

	/// <summary>
	/// Món ăn Việt Nam
	/// </summary>
	abstract class VietnameseFood
	{
		public abstract void HienThi();
	}

	/// <summary>
	/// Canh chua Cá lóc
	/// </summary>
	class CanhChua : VietnameseFood
	{
		string CaLoc;
		string QuaThom;
		string CaChua;
		string Me;

		public CanhChua(string caLoc, string quaThom, string caChua, string me)
		{
			CaLoc = caLoc;
			QuaThom = quaThom;
			CaChua = caChua;
			Me = me;
		}

		public override void HienThi()
		{
			Console.WriteLine("Nguyen lieu cua mon Canh chua ca loc:");
			Console.WriteLine("\tCa loc: {0}", CaLoc);
			Console.WriteLine("\tQua thom: {0}", QuaThom);
			Console.WriteLine("\tCa chua: {0}", CaChua);
			Console.WriteLine("\tMe: {0}\n", Me);
		}
	}

	/// <summary>
	/// Cá lóc kho tộ
	/// </summary>
	class CaKhoTo : VietnameseFood
	{
		string CaLoc;
		string NuocMam;
		string Ot;
		string HanhLa;

		public CaKhoTo(string caLoc, string nuocMam, string ot, string hanhLa)
		{
			CaLoc = caLoc;
			NuocMam = nuocMam;
			Ot = ot;
			HanhLa = hanhLa;
		}

		public override void HienThi()
		{
			Console.WriteLine("Nguyen lieu cua mon Ca loc kho to:");
			Console.WriteLine("\tCa loc: {0}", CaLoc);
			Console.WriteLine("\tNuoc mam: {0}", NuocMam);
			Console.WriteLine("\tOt: {0}", Ot);
			Console.WriteLine("\tHanhLa: {0}\n", HanhLa);
		}
	}

	/// <summary>
	/// Bánh xèo
	/// </summary>
	class BanhXeo : VietnameseFood
	{
		string BotBanhXeo;
		string ThitHeo;
		string Tom;
		string Gia;

		public BanhXeo(string botBanhXeo, string thitHeo, string tom, string gia)
		{
			BotBanhXeo = botBanhXeo;
			ThitHeo = thitHeo;
			Tom = tom;
			Gia = gia;
		}

		public override void HienThi()
		{
			Console.WriteLine("Nguyen lieu cua mon Banh xeo:");
			Console.WriteLine("\tBot banh xeo: {0}", BotBanhXeo);
			Console.WriteLine("\tThit heo: {0}", ThitHeo);
			Console.WriteLine("\tTom: {0}", Tom);
			Console.WriteLine("\tGia: {0}\n", Gia);
		}
	}

	/// <summary>
	/// Trình bày món ăn
	/// </summary>
	abstract class Decorator : VietnameseFood
	{
		protected VietnameseFood monAn;

		public Decorator(VietnameseFood dish)
		{
			this.monAn = dish;
		}

		public override void HienThi()
		{
			if (monAn != null)
			{
				monAn.HienThi();
			}
		}
	}

	/// <summary>
	/// Trạng thái của món ăn
	/// </summary>
	class Available : Decorator
	{
		public int SoLuong { get; set; }
		List<string> DSKhachHang = new List<string>();

		public Available(VietnameseFood monAn, int soLuong) : base(monAn)
		{
			this.SoLuong = soLuong;
		}

		public void OrderItem(string khachHang)
		{
			if (SoLuong > 0)
			{
				DSKhachHang.Add(khachHang);
				SoLuong--;
			}
			else
			{
				Console.WriteLine("\nDa het mon");
			}
		}

		public override void HienThi()
		{
			foreach (var khachHang in DSKhachHang)
			{
				Console.WriteLine("Mon an {0} duoc dat boi {1}", base.monAn, khachHang);
			}
		}
	}
}