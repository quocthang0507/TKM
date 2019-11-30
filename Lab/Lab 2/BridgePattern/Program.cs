using System;

namespace BridgePattern
{
	class Program
	{
		static void Main(string[] args)
		{
			Student student1 = new StudentUniversity("La Quoc Thang");
			student1.Subject = new DesignPattern();
			student1.Operation();

			student1.Subject = new SoftwareEngineering();
			student1.Operation();

			Console.ReadKey();
		}
	}

	abstract class Subject
	{
		public abstract void Register(string name);
	}

	class SoftwareEngineering : Subject
	{
		public override void Register(string name)
		{
			Console.WriteLine(name + " has just registered " + typeof(SoftwareEngineering).Name);
		}
	}

	class DesignPattern : Subject
	{
		public override void Register(string name)
		{
			Console.WriteLine(name + " has just registered " + typeof(DesignPattern).Name);
		}
	}

	class StudentUniversity : Student
	{
		public StudentUniversity(string name)
		{
			this.Name = name;
		}
		public override void Operation()
		{
			subject.Register(this.Name);
		}
	}

	abstract class Student
	{
		protected Subject subject;
		public string Name;
		public Subject Subject { set { subject = value; } }

		public abstract void Operation();

	}
}
