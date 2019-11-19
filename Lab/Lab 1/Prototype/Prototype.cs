namespace Prototype
{
	abstract class Prototype
	{
		public string ID { get; }

		public Prototype(string ID)
		{
			this.ID = ID;
		}

		public abstract Prototype Clone();
	}
}
