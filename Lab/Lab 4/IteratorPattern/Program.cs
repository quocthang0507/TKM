using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
	class Program
	{
		static void Main(string[] args)
		{
			ConcreteAggregate tapHop1 = new ConcreteAggregate();
			tapHop1[0] = "A";
			tapHop1[1] = "B";
			tapHop1[2] = "C";
			tapHop1[3] = "D";
			Iterator iterator = tapHop1.CreateIterator();
			Console.WriteLine("Iterating over collection");
			object item = iterator.First();
			while (item != null)
			{
				Console.WriteLine(item);
				item = iterator.Next();
			}
			Console.ReadKey();
		}
	}

	abstract class Aggregate
	{
		public abstract Iterator CreateIterator();
	}

	class ConcreteAggregate : Aggregate
	{
		private ArrayList items = new ArrayList();

		public override Iterator CreateIterator()
		{
			return new ConcreteIterator(this);
		}

		public int Count { get { return items.Count; } }

		public object this[int index]
		{
			get
			{
				return items[index];
			}
			set
			{
				items.Insert(index, value);
			}
		}

	}
	abstract class Iterator
	{
		public abstract object First();
		public abstract object Next();
		public abstract bool IsDone();
		public abstract object CurrentItem();
	}

	internal class ConcreteIterator : Iterator
	{
		private ConcreteAggregate concreteAggregate;
		private int current = 0;

		public ConcreteIterator(ConcreteAggregate concreteAggregate)
		{
			this.concreteAggregate = concreteAggregate;
		}

		public override object First()
		{
			return concreteAggregate[0];
		}

		public override object Next()
		{
			object result = null;
			if (current < concreteAggregate.Count - 1)
				result = concreteAggregate[++current];
			return result;
		}

		public override object CurrentItem()
		{
			return concreteAggregate[current];
		}

		public override bool IsDone()
		{
			return current > concreteAggregate.Count;
		}
	}
}
