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

	/// <summary>
	/// Component class: Cấu trúc chung cho cả tập tin và thư mục
	/// </summary>
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

	/// <summary>
	/// Leaf: Cấu trúc tập tin
	/// </summary>
	class File : Item
	{
		public File(string name) : base(name)
		{
		}

		/// <summary>
		/// Không thể thêm một đối tượng vào tập tin
		/// </summary>
		/// <param name="component"></param>
		public override void Add(Item component)
		{
			Console.WriteLine("Can't add folder or file to file");
		}

		/// <summary>
		/// Hiển thị vị trí tập tin
		/// </summary>
		/// <param name="depth"></param>
		public override void Display(int depth)
		{
			Console.WriteLine(new string('-', depth) + name);
		}

		/// <summary>
		/// Không thể xóa một đối tượng nào trong tập tin
		/// </summary>
		/// <param name="component"></param>
		public override void Remove(Item component)
		{
			Console.WriteLine("Can't remove folder or file from file");
		}
	}

	/// <summary>
	/// Composite: Cấu trúc thư mục
	/// </summary>
	class Folder : Item
	{
		private List<Item> children = new List<Item>();

		public Folder(string name) : base(name)
		{
		}

		/// <summary>
		/// Thêm một đối tượng vào thư mục
		/// </summary>
		/// <param name="component"></param>
		public override void Add(Item component)
		{
			children.Add(component);
		}

		/// <summary>
		/// Hiển thị nội dung bên trong thư mục
		/// </summary>
		/// <param name="depth"></param>
		public override void Display(int depth)
		{
			Console.WriteLine(new string('-', depth) + name);
			foreach (Item component in children)
			{
				component.Display(depth + 2);
			}
		}

		/// <summary>
		/// Xóa một đối tượng trong thư mục
		/// </summary>
		/// <param name="component"></param>
		public override void Remove(Item component)
		{
			children.Remove(component);
		}

	}
}
