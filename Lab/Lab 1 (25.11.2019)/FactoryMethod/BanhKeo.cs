using System;

namespace FactoryMethod
{
	/// <summary>
	/// Product class
	/// </summary>
	abstract class BanhKeo
	{
		/// <summary>
		/// Ten san pham
		/// </summary>
		public string TenSanPham { get; set; }

		/// <summary>
		/// Ngay san xuat banh keo
		/// </summary>
		public DateTime NgaySanXuat { get; set; }

		/// <summary>
		/// Han su dung banh keo
		/// </summary>
		public DateTime HanSuDung { get; set; }

		/// <summary>
		/// Khoi luong cua banh keo (don vi: gram)
		/// </summary>
		public double KhoiLuong { get; set; }

		public override string ToString()
		{
			return string.Format("Ten san pham: {0}, Ngay san xuat: {1}, Han su dung: {2}, Khoi luong (g): {3}", TenSanPham, NgaySanXuat.ToString("dd/MM/yyyy"), HanSuDung.ToString("dd/MM/yyyy"), KhoiLuong);
		}
	}
}
