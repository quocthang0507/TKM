namespace Lab_1
{
	class Client
	{
		private AbstractProductA abstractProductA;
		private AbstractProductB abstractProductB;

		public Client(AbstractFactory factory)
		{
			abstractProductA = factory.CreateProductA();
			abstractProductB = factory.CreateProductB();
		}

		public void Run()
		{
			abstractProductB.Interact(abstractProductA);
		}
	}
}
