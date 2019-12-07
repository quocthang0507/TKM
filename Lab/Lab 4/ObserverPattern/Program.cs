using System;
using System.Collections.Generic;

namespace ObserverPattern
{
	class Program
	{
		static void Main(string[] args)
		{
			VietnamAirline VNA = new VietnamAirline("HVN", 35.15);
			Console.WriteLine(VNA.ToString());
			NhaDauTu a = new NhaDauTuNuocNgoai("Park Hang-seo");
			NhaDauTu b = new NhaDauTuNuocNgoai("Park Seo-hang");
			VNA.Attach(a);
			VNA.Attach(b);
			Console.WriteLine("Thay doi gia co phieu len 35.2:");
			VNA.Gia = 35.2;
			Console.ReadKey();
		}
	}

	/// <summary>
	/// Subject class
	/// </summary>
	abstract class CoPhieu
	{
		public string Ten { get; }
		private double gia;
		private List<NhaDauTu> NhaDauTu = new List<NhaDauTu>();

		public CoPhieu(string ten, double gia)
		{
			this.Ten = ten;
			this.gia = gia;
		}

		public void Attach(NhaDauTu nhaDauTu)
		{
			this.NhaDauTu.Add(nhaDauTu);
		}

		public void Detach(NhaDauTu nhaDauTu)
		{
			NhaDauTu.Remove(nhaDauTu);
		}

		public void Notify()
		{
			foreach (NhaDauTu observer in NhaDauTu)
			{
				observer.Update(this);
			}
		}

		public double Gia
		{
			get { return gia; }
			set
			{
				if (gia != value)
				{
					gia = value;
					Notify();
				}
			}
		}

		public override string ToString()
		{
			return string.Format("Co phieu {0} voi gia ban dau la {1:C}", Ten, Gia);
		}
	}

	/// <summary>
	/// ConcreteSubject class
	/// </summary>
	class VietnamAirline : CoPhieu
	{
		public VietnamAirline(string ten, double gia) : base(ten, gia) { }
	}

	/// <summary>
	/// Observer class
	/// </summary>
	abstract class NhaDauTu
	{
		public abstract void Update(CoPhieu coPhieu);
	}

	/// <summary>
	/// ConcreteObserver class
	/// </summary>
	class NhaDauTuNuocNgoai : NhaDauTu
	{
		private string ten;

		public NhaDauTuNuocNgoai(string ten)
		{
			this.ten = ten;
		}

		public override void Update(CoPhieu coPhieu)
		{
			Console.WriteLine("Nha dau tu {0} da nhan duoc thong bao gia co phieu {1} doi thanh {2:C}", ten, coPhieu.Ten, coPhieu.Gia);
		}
	}
}
