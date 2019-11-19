using System;

namespace FactoryMethodRealWorld
{
	class Program
	{
		static void Main(string[] args)
		{
			Document[] documents = new Document[2];

			documents[0] = new Resume();
			documents[1] = new Report();

			foreach (var document in documents)
			{
				Console.WriteLine("\n" + document.GetType().Name + "--");
				foreach (var page in document.Pages)
				{
					Console.WriteLine("\t" + page.GetType().Name);
				}
			}

			Console.ReadKey();
		}
	}
}
