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

		public event DelegatForEvent EventFor // EVENT
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
		static private void HandlerForEvent1() //  
		{
			Console.WriteLine("Handler #1");
		}

		static private void HandlerForEvent2()
		{
			Console.WriteLine("Handler #2");
		}

		static void Main(string[] args)
		{
			MyClass instance = new MyClass();

			instance.EventFor += new DelegatForEvent(HandlerForEvent1);
			instance.EventFor += new DelegatForEvent(HandlerForEvent2);

			instance.InvokeEvent();

			Console.WriteLine(new string('-', 20));

			instance.EventFor -= new DelegatForEvent(HandlerForEvent2);
			instance.InvokeEvent();

			// Delay.
			Console.ReadKey();
		}
	}
}
