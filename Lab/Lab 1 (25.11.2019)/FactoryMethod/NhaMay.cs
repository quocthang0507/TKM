namespace FactoryMethod
{
	/// <summary>
	/// Creator class
	/// </summary>
	abstract class NhaMay
	{
		/// <summary>
		/// Ten nha may
		/// </summary>
		public string TenNhaMay;

		/// <summary>
		/// Dia chi cua nha may
		/// </summary>
		public string DiaChi;

		/// <summary>
		/// So dien thoai lien lac
		/// </summary>
		public string SoDienThoai;

		/// <summary>
		/// Tao ra banh keo
		/// </summary>
		/// <returns>Banh keo</returns>
		public abstract BanhKeo SanXuat();

		public override string ToString()
		{
			return string.Format("Ten nha may: {0}, Dia chi: {1}, So dien thoai: {2} \n\t{3}", TenNhaMay, DiaChi, SoDienThoai, SanXuat().ToString());
		}
	}
}
