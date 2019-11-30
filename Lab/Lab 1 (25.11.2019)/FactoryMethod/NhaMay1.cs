using System;

namespace FactoryMethod
{
	class NhaMay1 : NhaMay
	{
		public NhaMay1(string tenNhaMay, string diaChi, string soDienThoai)
		{
			TenNhaMay = tenNhaMay;
			DiaChi = diaChi;
			SoDienThoai = soDienThoai;
		}

		public override BanhKeo SanXuat()
		{
			return new BanhGao("Banh Gao Vi Bo", DateTime.Now, DateTime.Now.AddYears(1), 100);
		}
	}
}
