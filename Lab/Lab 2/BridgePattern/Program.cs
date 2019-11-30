using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
	class Program
	{
		static void Main(string[] args)
		{
			Abstraction abstraction = new RefinedAbstraction();
			abstraction.Implementor = new ConcreteImplementorA();
			abstraction.Operation();

			abstraction.Implementor = new ConcreteImplementorB();
			abstraction.Operation();

			Console.ReadKey();
		}
	}

	class ConcreteImplementorB : Implementor
	{
		public override void Operation()
		{
			Console.WriteLine("ConcreteImplementorB Operation");
		}
	}

	class ConcreteImplementorA : Implementor
	{
		public override void Operation()
		{
			Console.WriteLine("ConcreteImplementorA Operation");
		}
	}

	internal class RefinedAbstraction : Abstraction
	{
		public override void Operation()
		{
			implementor.Operation();
		}
	}

	class Abstraction
	{
		protected Implementor implementor;
		public Implementor Implementor { set { implementor = value; } }

		public virtual void Operation()
		{
			implementor.Operation();
		}
	}

	abstract class Implementor
	{
		public abstract void Operation();
	}
}
