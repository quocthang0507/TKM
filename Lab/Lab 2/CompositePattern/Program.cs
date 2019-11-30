using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
	class Program
	{
		static void Main(string[] args)
		{
			Composite root = new Composite("root");
			root.Add(new Leaf("Left A"));
			root.Add(new Leaf("Left B"));

			Composite composite = new Composite("Composite X");
			composite.Add(new Leaf("Left A of Composite X"));
			composite.Add(new Leaf("Left B of Composite X"));

			root.Add(composite);
			root.Add(new Leaf("Leaf C"));

			Leaf leaf = new Leaf("Leaf D");
			root.Add(leaf);
			root.Remove(leaf);

			root.Display(1);

			Console.ReadKey();
		}
	}

	class Leaf : Component
	{
		public Leaf(string name) : base(name)
		{
		}

		public override void Add(Component component)
		{
			Console.WriteLine("Can't add to leaf");
		}

		public override void Display(int depth)
		{
			Console.WriteLine(new string('-', depth) + name);
		}

		public override void Remove(Component component)
		{
			Console.WriteLine("Can't remove from a leaf");
		}
	}

	abstract class Component
	{
		protected string name;

		protected Component(string name)
		{
			this.name = name;
		}

		public abstract void Add(Component component);
		public abstract void Remove(Component component);
		public abstract void Display(int depth);
	}

	internal class Composite : Component
	{
		private List<Component> children = new List<Component>();

		public Composite(string name) : base(name)
		{
		}

		public override void Add(Component component)
		{
			children.Add(component);
		}

		public override void Display(int depth)
		{
			Console.WriteLine(new string('-', depth) + name);
			foreach (Component component in children)
			{
				component.Display(depth + 2);
			}
		}

		public override void Remove(Component component)
		{
			children.Remove(component);
		}

	}
}
