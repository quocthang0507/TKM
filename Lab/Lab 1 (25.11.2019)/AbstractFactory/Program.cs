using System;

namespace AbstractFactory
{
	/// <summary>
	/// Lớp AbstractFactory, định nghĩa các phương thức để tạo các đối tượng trừu tượng.
	/// </summary>
	abstract class NhaMayCheBienThucAn
	{
		public abstract ThitQuay LamThitQuay();
		public abstract ChaGio LamChaGio();
	}

	/// <summary>
	/// Lớp Product A
	abstract class ThitQuay { }

	/// <summary>
	/// Lớp Product B
	/// </summary>
	abstract class ChaGio { }

	/// <summary>
	///A ConcreteProduct
	/// </summary>
	class ThitHeoQuayChay : ThitQuay { }

	/// <summary>
	/// A ConcreteProduct
	/// </summary>
	class ChaGioNam : ChaGio { }

	/// <summary>
	/// A concrete object
	/// </summary>
	class ThitHeoQuay : ThitQuay { }

	/// <summary>
	/// A concrete object
	/// </summary>
	class ChaGioThit : ChaGio { }

	/// <summary>
	/// A concrete factory which creates concrete objects by implementing the abstract factory's methods.
	/// </summary>
	class NhaMayMonChay : NhaMayCheBienThucAn
	{
		public override ThitQuay LamThitQuay()
		{
			Console.WriteLine("\nThit heo quay chay");
			return new ThitHeoQuayChay();
		}

		public override ChaGio LamChaGio()
		{
			Console.WriteLine("\nCha gio nam");
			return new ChaGioNam();
		}
	}

	/// <summary>
	/// A ConcreteFactory which creates concrete objects by implementing the abstract factory's methods.
	/// </summary>
	class NhaMayMonMan : NhaMayCheBienThucAn
	{
		public override ThitQuay LamThitQuay()
		{
			Console.WriteLine("\nThit heo quay");
			return new ThitHeoQuay();
		}

		public override ChaGio LamChaGio()
		{
			Console.WriteLine("\nCha gio thit");
			return new ChaGioThit();
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			char input;
			NhaMayCheBienThucAn nhaMay;

			Console.WriteLine("Ban muon An (c)hay hay An (m)an?");
			input = Console.ReadKey().KeyChar;

			switch (input)
			{
				case 'c':
				case 'C':
					nhaMay = new NhaMayMonChay();
					break;
				case 'm':
				case 'M':
					nhaMay = new NhaMayMonMan();
					break;
				default:
					Console.WriteLine("\nBan nhap sai!");
					return;
			}

			Console.WriteLine("\nBan muon (T)hit quay hay (C)ha gio?");
			input = Console.ReadKey().KeyChar;

			switch (input)
			{
				case 't':
				case 'T':
					nhaMay.LamThitQuay();
					break;
				case 'c':
				case 'C':
					nhaMay.LamChaGio();
					break;
				default:
					Console.WriteLine("\nBan nhap sai!");
					return;
			}

			Console.ReadKey();

		}
	}
}
