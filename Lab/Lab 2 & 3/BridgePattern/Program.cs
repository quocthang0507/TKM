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

	/// <summary>
	/// Implementation class: Môn học
	/// </summary>
	abstract class Subject
	{
		/// <summary>
		/// Đăng ký môn học
		/// </summary>
		/// <param name="name">Sinh viên đăng ký</param>
		public abstract void Register(string name);
	}

	/// <summary>
	/// ConcreteImplementation: Môn Công nghệ phần mềm
	/// </summary>
	class SoftwareEngineering : Subject
	{
		/// <summary>
		/// Đăng ký môn học Công nghệ phần mềm
		/// </summary>
		/// <param name="name">Sinh viên đăng ký</param>
		public override void Register(string name)
		{
			Console.WriteLine(name + " has just registered " + typeof(SoftwareEngineering).Name);
		}
	}

	/// <summary>
	/// ConcreteImplementation: Môn Thiết kế mẫu
	/// </summary>
	class DesignPattern : Subject
	{
		/// <summary>
		/// Đăng ký môn học Thiết kế mẫu
		/// </summary>
		/// <param name="name">Sinh viên đăng ký</param>
		public override void Register(string name)
		{
			Console.WriteLine(name + " has just registered " + typeof(DesignPattern).Name);
		}
	}

	/// <summary>
	/// Abstraction class: Sinh viên
	/// </summary>
	abstract class Student
	{
		protected Subject subject;
		public string Name;
		public Subject Subject { set { subject = value; } }

		/// <summary>
		/// Hành động tương tác với môn học
		/// </summary>
		public abstract void Operation();
	}

	/// <summary>
	/// Concrete Abstraction: Sinh viên đại học
	/// </summary>
	class StudentUniversity : Student
	{
		public StudentUniversity(string name)
		{
			this.Name = name;
		}

		/// <summary>
		/// Hành động tương tác với môn học
		/// </summary>
		public override void Operation()
		{
			subject.Register(this.Name);
		}
	}
}
