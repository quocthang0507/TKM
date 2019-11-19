namespace Prototype
{
	class ConcretePrototype1 : Prototype
	{
		public ConcretePrototype1(string ID) : base(ID) { }

		public override Prototype Clone()
		{
			return (Prototype)this.MemberwiseClone();
		}
	}
}
