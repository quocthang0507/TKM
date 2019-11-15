using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
	/// <summary>
	/// Alternating current (AC): Dòng điện xoay chiều
	/// </summary>
	class AC
	{
		double MinVoltage = 100;
		double MaxVoltage = 240;
		double Ampere = 1.7;
		int MinFreq = 50;
		int MaxFreq = 60;

		public override string ToString()
		{
			return string.Format("{0}-{1}V ~ {2}A {3}-{4}Hz", MinVoltage, MaxVoltage, Ampere, MinFreq, MaxFreq);
		}
	}

	/// <summary>
	/// Direct current (DC): Dòng điện một chiều
	/// </summary>
	class DC
	{
		double Voltage = 18.5;
		double Ampere = 3.5;

		public override string ToString()
		{
			return string.Format("{0}V - {1}A", Voltage, Ampere);
		}
	}

	/// <summary>
	/// Adapter (Charger): Cục sạc laptop chuyển dòng điện AC thành DC
	/// </summary>
	class Adapter : DC
	{
		private AC ac = new AC();

		public override string ToString()
		{
			return ac.ToString();
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			DC dc = new Adapter();
			Console.WriteLine(dc);
			Console.ReadKey();
		}
	}
}
