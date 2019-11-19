using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryRealWorld
{
	class AnimalWorld
	{
		private Herbivore herbivore;
		private Carnivore carnivore;

		public AnimalWorld(ContinentFactory factory)
		{
			carnivore = factory.CreateCarnivore();
			herbivore = factory.CreateHerbivore();
		}

		public void RunFoodChain()
		{
			carnivore.Eat(herbivore);
		}
	}
}
