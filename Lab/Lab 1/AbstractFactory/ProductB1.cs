using System;

namespace Lab_1
{
	class ProductB1 : AbstractProductB
	{
		public override void Interact(AbstractProductA a)
		{
			Console.WriteLine(this.GetType().Name + " interacts with " + a.GetType().Name);
		}
	}
}
