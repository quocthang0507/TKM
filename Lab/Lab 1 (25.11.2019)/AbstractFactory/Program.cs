using System;

namespace AbstractFactory
{
	/// <summary>
	///  lớp abstract
	/// </summary>
	abstract class Sandwich { }

	/// <summary>
	/// lớp abstract
	/// </summary>
	abstract class Dessert { }

	/// <summary>
	/// Lớp AbstractFactory, định nghĩa các phương thức để tạo các đối tượng trừu tượng.
	/// </summary>
	abstract class RecipeFactory
	{
		public abstract Sandwich CreateSandwich();
		public abstract Dessert CreateDessert();
	}

	/// <summary>
	///A ConcreteProduct
	/// </summary>
	class BLT : Sandwich { }

	/// <summary>
	/// A ConcreteProduct
	/// </summary>
	class CremeBrulee : Dessert { }

	/// <summary>
	/// A concrete object
	/// </summary>
	class GrilledCheese : Sandwich { }

	/// <summary>
	/// A concrete object
	/// </summary>
	class IceCreamSundae : Dessert { }

	/// <summary>
	/// A concrete factory which creates concrete objects by implementing the abstract factory's methods.
	/// </summary>
	class KidCuisineFactory : RecipeFactory
	{
		public override Sandwich CreateSandwich()
		{
			return new GrilledCheese();
		}

		public override Dessert CreateDessert()
		{
			return new IceCreamSundae();
		}
	}

	/// <summary>
	/// A ConcreteFactory which creates concrete objects by implementing the abstract factory's methods.
	/// </summary>
	class AdultCuisineFactory : RecipeFactory
	{
		public override Sandwich CreateSandwich()
		{
			return new BLT();
		}

		public override Dessert CreateDessert()
		{
			return new CremeBrulee();
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Who are you? (A)dult or (C)hild?");
			char input = Console.ReadKey().KeyChar;
			RecipeFactory factory;
			switch (input)
			{
				case 'a':
				case 'A':
					factory = new AdultCuisineFactory();
					break;

				case 'c':
				case 'C':
					factory = new KidCuisineFactory();
					break;

				default:
					Console.WriteLine("Input error");
					Console.ReadKey();
					return;

			}

			var sandwich = factory.CreateSandwich();
			var dessert = factory.CreateDessert();

			Console.WriteLine("\nSandwich: " + sandwich.GetType().Name);
			Console.WriteLine("Dessert: " + dessert.GetType().Name);

			Console.ReadKey();

		}
	}
}
