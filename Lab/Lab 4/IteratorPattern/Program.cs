using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
	class Program
	{
		static void Main(string[] args)
		{
			KhoHangDaLat khoHangDL = new KhoHangDaLat();
			khoHangDL[0] = new SanPham("Keo Deo Chupa Chups Sour Belt (32 cai)", 63000, "Chupa Chups");
			khoHangDL[1] = new SanPham("Banh geo Nhat Ichi (180g)", 32000, "Ichi");
			khoHangDL[2] = new SanPham("Banh Chocopie hop 12 cai vi ca cao (360g)", 52200, "Chocopie");
			khoHangDL[3] = new SanPham("Thung 30 goi mi snack huong Ga Nuong (16g)", 99000, "Gemez Enaak");
			NhanVienKiemKe nhanVienDL = new NhanVienKiemKeDaLat(khoHangDL);

			Console.WriteLine("Nhan vien dang kiem ke hang hoa trong kho hang Da Lat...");

			object item = nhanVienDL.First();
			while (item != null)
			{
				Console.WriteLine(item);
				item = nhanVienDL.Next();
			}
			Console.ReadKey();
		}
	}

	class SanPham
	{
		public string TenSanPham;
		public double Gia;
		public string CongTy;

		public SanPham(string tenSP, double gia, string congTy)
		{
			TenSanPham = tenSP;
			Gia = gia;
			CongTy = congTy;
		}

		public override string ToString()
		{
			return string.Format("*** San pham: {0} co gia {1} duoc san xuat tai {2}", TenSanPham, Gia, CongTy);
		}
	}

	/// <summary>
	/// Aggregate class
	/// </summary>
	abstract class KhoHang
	{
	}

	/// <summary>
	/// Concrete aggregate class
	/// </summary>
	class KhoHangDaLat : KhoHang
	{
		private List<SanPham> HangHoaTrongKho = new List<SanPham>();

		public int SoLuong { get { return HangHoaTrongKho.Count; } }

		public object this[int index]
		{
			get => HangHoaTrongKho[index];
			set => HangHoaTrongKho.Add(value as SanPham);
		}

	}

	/// <summary>
	/// Nhan vien ke ke hang hoa
	/// </summary>
	abstract class NhanVienKiemKe
	{
		public abstract object First();
		public abstract object Next();
		public abstract bool IsDone();
		public abstract object CurrentItem();
	}

	/// <summary>
	/// Concrete Iterator class
	/// </summary>
	class NhanVienKiemKeDaLat : NhanVienKiemKe
	{
		private KhoHangDaLat hangHoa;
		private int HienTai = 0;

		public NhanVienKiemKeDaLat(KhoHangDaLat khoHang)
		{
			this.hangHoa = khoHang;
		}

		public override object First()
		{
			return hangHoa[0];
		}

		public override object Next()
		{
			object result = null;
			if (HienTai < hangHoa.SoLuong - 1)
				result = hangHoa[++HienTai];
			return result;
		}

		public override object CurrentItem()
		{
			return hangHoa[HienTai];
		}

		public override bool IsDone()
		{
			return HienTai > hangHoa.SoLuong;
		}
	}
}
