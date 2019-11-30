using System;
using System.Text;

namespace Prototype
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.OutputEncoding = Encoding.UTF8;
			Console.WriteLine("Input your information please!");
			UserInfomation user = new UserInfomation();
			user.Input();
			Console.Write("\nDo you want to change your information? (Press Y/y if Yes, other if No)");
			char c = Console.ReadKey().KeyChar;
			UserInfomation oldInfo = user.Clone() as UserInfomation;
			if (c == 'Y' || c == 'y')
			{
				Console.ReadKey();
				Console.WriteLine();
				user.ChangeInfo();
			}
			Console.WriteLine("\nYour old information is:");
			oldInfo.ShowInfo();
			Console.WriteLine("\nYour new information is:");
			user.ShowInfo();
			Console.ReadKey();
		}
	}
}
