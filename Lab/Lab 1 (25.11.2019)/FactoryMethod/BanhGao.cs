using System;

namespace FactoryMethod
{
	/// <summary>
	/// ConcreteProduct class
	/// </summary>
	class BanhGao : BanhKeo
	{
		public BanhGao(string tenSanPham, DateTime ngaySanXuat, DateTime hanSuDung, double khoiLuong)
		{
			TenSanPham = tenSanPham;
			NgaySanXuat = ngaySanXuat;
			HanSuDung = hanSuDung;
			KhoiLuong = khoiLuong;
		}

		public override string ToString()
		{
			return base.ToString();
		}
	}
}
