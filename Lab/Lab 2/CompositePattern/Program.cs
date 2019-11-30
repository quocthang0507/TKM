using System;
using System.Collections.Generic;

namespace CompositePattern
{
	class Program
	{
		static void Main(string[] args)
		{
			Folder root = new Folder(@"root (D:\)");
			root.Add(new File("De thi.docx"));
			root.Add(new File("Bai lam.docx"));

			Folder hinhAnh = new Folder("Hinh anh");
			hinhAnh.Add(new File("da lat.jpg"));
			hinhAnh.Add(new File("dai hoc da lat.jpg"));
			root.Add(hinhAnh);

			root.Add(new File("Tro choi.exe"));

			File temp = new File("temp.tmp");
			root.Add(temp);
			Console.WriteLine("Cay thu muc truoc khi xoa: ");
			root.Display(2);
			root.Remove(temp);
			Console.WriteLine("\nCay thu muc sau khi xoa: ");
			root.Display(2);

			Console.ReadKey();
		}
	}

	abstract class Item
	{
		protected string name;

		protected Item(string name)
		{
			this.name = name;
		}

		public abstract void Add(Item component);
		public abstract void Remove(Item component);
		public abstract void Display(int depth);
	}

	class File : Item
	{
		public File(string name) : base(name)
		{
		}

		public override void Add(Item component)
		{
			Console.WriteLine("Can't add folder or file to file");
		}

		public override void Display(int depth)
		{
			Console.WriteLine(new string('-', depth) + name);
		}

		public override void Remove(Item component)
		{
			Console.WriteLine("Can't remove folder or file from file");
		}
	}

	class Folder : Item
	{
		private List<Item> children = new List<Item>();

		public Folder(string name) : base(name)
		{
		}

		public override void Add(Item component)
		{
			children.Add(component);
		}

		public override void Display(int depth)
		{
			Console.WriteLine(new string('-', depth) + name);
			foreach (Item component in children)
			{
				component.Display(depth + 2);
			}
		}

		public override void Remove(Item component)
		{
			children.Remove(component);
		}

	}
}
