namespace Prototype
{
	class ConcretePrototype2 : Prototype
	{
		public ConcretePrototype2(string ID) : base(ID)
		{

		}

		public override Prototype Clone()
		{
			return (Prototype)this.MemberwiseClone();
		}
	}
}
