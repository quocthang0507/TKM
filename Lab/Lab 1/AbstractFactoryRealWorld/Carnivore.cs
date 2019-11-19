using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryRealWorld
{
	/// <summary>
	/// Dong vat an thit, an dong vat an co
	/// </summary>
	abstract class Carnivore
	{
		public abstract void Eat(Herbivore h);
	}
}
