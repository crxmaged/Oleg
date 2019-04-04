using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstSimpleEvent
{
	public delegate void DelegatForEvent(); // We need delegate for event

	class MyClass
	{
		DelegatForEvent field; // field - use in event

		public event DelegatForEvent EventFor // EVENT - like a property
		{
			add { field += value; }
			remove { field -= value; }
		}

		public void InvokeEvent()
		{
			field.Invoke();
		}
	}

	class Program
	{
		static private void HandlerForEvent1() // handler of event #1
		{
			Console.WriteLine("Handler #1");
		}

		static private void HandlerForEvent2() // handler of event #2
		{
			Console.WriteLine("Handler #2");
		}

		static void Main(string[] args)
		{
			MyClass instance = new MyClass(); // instance for work with class MyClass and member in class

			instance.EventFor += new DelegatForEvent(HandlerForEvent1); // set handler 1 to event
			instance.EventFor += new DelegatForEvent(HandlerForEvent2); // set handler 2 to event

			instance.InvokeEvent(); // Invoke event like delegate

			Console.WriteLine(new string('-', 20)); 

			instance.EventFor -= new DelegatForEvent(HandlerForEvent2); // remove handler 2 in event
			instance.InvokeEvent(); // Invoke event like delegate

			// Delay.
			Console.ReadKey();
		}
	}
}
