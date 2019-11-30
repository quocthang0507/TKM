using System;

namespace FactoryMethod
{
	class NhaMay2 : NhaMay
	{
		public NhaMay2(string tenNhaMay, string diaChi, string soDienThoai)
		{
			TenNhaMay = tenNhaMay;
			DiaChi = diaChi;
			SoDienThoai = soDienThoai;
		}

		public override BanhKeo SanXuat()
		{
			return new KeoDua("Keo Dua Sua", DateTime.Now, DateTime.Now.AddYears(1), 250);
		}
	}
}
