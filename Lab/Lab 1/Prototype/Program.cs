using System;

namespace Prototype
{
	class Program
	{
		static void Main(string[] args)
		{
			ConcretePrototype1 p1 = new ConcretePrototype1("1610207");
			ConcretePrototype1 copy1 = (ConcretePrototype1)p1.Clone();
			Console.WriteLine("Cloned: {0}", copy1.ID);

			ConcretePrototype2 p2 = new ConcretePrototype2("La Quoc Thang");
			ConcretePrototype2 copy2 = (ConcretePrototype2)p2.Clone();
			Console.WriteLine("Cloned: {0}", copy2.ID);

			Console.ReadKey();
		}
	}
}
