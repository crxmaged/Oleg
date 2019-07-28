using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace UseDelegateAndEvent.CommonFiles
{
	// delegate: method with one param "string" and return "void" - nothing
	public delegate void ShowMessage(string message);

	public class Studet
	{
		// ethod Move - step by student 
		public void Move (int disrance) // distance count of step 
		{
			for (int i = 1; i <= disrance; i++)
			{
				Thread.Sleep(1000); // mini pause
				// Call Moving
				// Moving(string.Format("Step {0}", i)); // give that value to univesal method: uniMethod
				if (Moving != null)
				{
					Moving(this, new MovingEventArgs(string.Format("Step {0}", i))); // shape (forma) of event!
				}
			}
		}
		/*
		// Property Moving with generic type Action (delegat)
		public Action<string> Moving { get; set; }
		*/
		// creat event/delegate like a property
		public event EventHandler<MovingEventArgs> Moving; // event-delegate check Megod Student_Moving
	}
}
