using System.Collections.Generic;

namespace FactoryMethodRealWorld
{
	abstract class Document
	{
		private List<Page> pages = new List<Page>();

		public Document()
		{
			this.CreatePages();
		}

		public List<Page> Pages { get { return pages; } }

		public abstract void CreatePages();
	}
}
