using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
	class Program
	{
		static void Main(string[] args)
		{
			Receiver reveiver = new Receiver();
			Command command = new ConcreteCommand(reveiver);
			Invoker invoker = new Invoker();
			invoker.SetCommand(command);
			invoker.ExecuteCommand();
			Console.ReadKey();
		}
	}

	abstract class Command
	{
		protected Receiver receiver;

		public Command(Receiver receiver)
		{
			this.receiver = receiver;
		}

		public abstract void Execute();
	}

	class ConcreteCommand : Command
	{
		public ConcreteCommand(Receiver receiver) : base(receiver) { }

		public override void Execute()
		{
			receiver.Action();
		}
	}

	class Receiver
	{
		public void Action()
		{
			Console.WriteLine("Called Receiver Action()");
		}
	}

	class Invoker
	{
		private Command command;

		public void ExecuteCommand()
		{
			command.Execute();
		}

		public void SetCommand(Command command)
		{
			this.command = command;
		}

	}
}
