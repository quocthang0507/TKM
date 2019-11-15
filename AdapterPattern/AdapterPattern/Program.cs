using System;
using System.Text;

namespace AdapterPattern
{
	/// <summary>
	/// Alternating current (AC): Dòng điện xoay chiều
	/// </summary>
	class AC
	{
		private readonly double MinVoltage = 100;
		private readonly double MaxVoltage = 240;
		private readonly double Ampere = 1.7;
		private readonly int MinFreq = 50;
		private readonly int MaxFreq = 60;

		/// <summary>
		/// Cung cấp đầu vào là một nguồn điện xoay chiều
		/// </summary>
		/// <returns>Trạng thái của dòng điện</returns>
		public string InputSource()
		{
			return string.Format("Input: {0}-{1}V ~ {2}A {3}-{4}Hz", MinVoltage, MaxVoltage, Ampere, MinFreq, MaxFreq);
		}
	}

	/// <summary>
	/// Direct current (DC): Dòng điện một chiều
	/// </summary>
	class DC
	{
		private readonly double Voltage = 18.5;
		private readonly double Ampere = 3.5;

		/// <summary>
		/// Cung cấp đầu ra là một nguồn điện một chiều
		/// </summary>
		/// <returns>Trạng thái của dòng điện</returns>
		public virtual string OutputSource()
		{
			return string.Format("Output: {0}V - {1}A", Voltage, Ampere);
		}
	}

	/// <summary>
	/// Adapter (Charger): Cục sạc laptop chuyển dòng điện AC thành DC
	/// </summary>
	class Adapter : DC
	{
		/// <summary>
		/// Lấy nguồn điện xoay chiều
		/// </summary>
		private readonly AC ac = new AC();

		/// <summary>
		/// Tạo ra dòng điện một chiều
		/// </summary>
		/// <returns>Thông tin quá trình chuyển đổi</returns>
		public override string OutputSource()
		{
			StringBuilder builder = new StringBuilder();
			builder.AppendLine(ac.InputSource());
			builder.AppendLine(base.OutputSource());
			builder.Append("Succeed");
			return builder.ToString();
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			DC dc = new Adapter();
			Console.WriteLine(dc.OutputSource());
			Console.ReadKey();
		}
	}
}
