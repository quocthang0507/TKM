using System;

namespace Prototype
{
	public class UserInfomation : Prototype
	{
		private string name;
		private string address;
		private int age;

		public string Address
		{
			get { return address; }
			set { address = value; }
		}

		public int Age
		{
			get { return age; }
			set { age = value; }
		}

		public string Name
		{
			get { return name; }
			set { name = value; }
		}

		internal void Input()
		{
			Console.Write("Input your name: ");
			this.name = Console.ReadLine();
			Console.Write("Input your address: ");
			this.address = Console.ReadLine();
			while (true)
			{
				Console.Write("Input your age: ");
				try
				{
					this.age = int.Parse(Console.ReadLine());
					break;
				}
				catch (Exception e)
				{
					Console.WriteLine("Error of input, please input right type!!!");
				}
			}
		}

		public void ChangeInfo()
		{
			Input();
		}

		public void ShowInfo()
		{
			Console.WriteLine("Name: " + this.Name);
			Console.WriteLine("Address: " + this.Address);
			Console.WriteLine("Age: " + this.Age);
		}

		public Prototype Clone()
		{
			return (Prototype)this.MemberwiseClone();
		}
	}
}
