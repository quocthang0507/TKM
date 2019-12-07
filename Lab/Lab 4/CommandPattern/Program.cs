using System;

namespace CommandPattern
{
	class Program
	{
		static void Main(string[] args)
		{
			DauBepMonQuay dauBep1 = new DauBepMonQuay();
			DauBepMonKho dauBep2 = new DauBepMonKho();

			DatMonAn khachGoiMon = new ThitHeoKhoTo();
			NguoiPhucVu nhanVienPhucVu = new NguoiPhucVu(khachGoiMon);

			Console.ReadKey();
		}
	}

	/// <summary>
	/// Command class
	/// </summary>
	abstract class DatMonAn
	{
		public abstract void ThucHien();
	}

	/// <summary>
	/// Concrete Command class
	/// </summary>
	class ThitHeoKhoTo : DatMonAn
	{
		private DauBepMonKho dauBep;

		public ThitHeoKhoTo()
		{
			dauBep = new DauBepMonKho();
		}

		public override void ThucHien()
		{
			dauBep.ThucHienMonAn();
			Console.WriteLine(this.ToString());
		}

		public override string ToString()
		{
			return "Mon Thit heo kho to da hoan tat";
		}
	}

	/// <summary>
	/// Concrete Command class
	/// </summary>
	class ThitHeoQuay : DatMonAn
	{
		private DauBepMonQuay dauBep;

		public ThitHeoQuay()
		{
			dauBep = new DauBepMonQuay();
		}

		public override void ThucHien()
		{
			dauBep.ThucHienMonAn();
			Console.WriteLine(this.ToString());
		}

		public override string ToString()
		{
			return "Mon Thit heo quay hoan tat";
		}
	}

	/// <summary>
	/// Receiver 1
	/// </summary>
	class DauBepMonQuay
	{
		public void ThucHienMonAn()
		{
			Console.WriteLine("Dau bep dang quay thit heo...");
		}
	}


	/// <summary>
	/// Receiver 2
	/// </summary>
	class DauBepMonKho
	{
		public void ThucHienMonAn()
		{
			Console.WriteLine("Dau bep dang kho thit...");
		}
	}

	/// <summary>
	/// Invoker
	/// </summary>
	class NguoiPhucVu
	{
		private DatMonAn goiMon;

		public NguoiPhucVu(DatMonAn goiMon)
		{
			this.goiMon = goiMon;
			ExecuteCommand();
		}

		public void ExecuteCommand()
		{
			goiMon.ThucHien();
			Console.WriteLine("Mang mon an cho khach hang thuong thuc");
		}

	}
}
