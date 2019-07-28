using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseDelegateAndEvent.CommonFiles;

namespace UseDelegateAndEvent
{
	class Program
	{
		static void Main(string[] args)
		{
			Studet student = new Studet();  // instance class 
			// give to delegate method Show and check it
			// ShowMessage method = Show;
			// set count step for student

			// (1) Property Moving type Action (delegat) assign method Show 
			/*
			student.Moving = Show; // 
			student.Move(7);
			*/

			student.Moving += Student_Moving; // (1) check for use event/delegate, and call method Student_Moving
			student.Move(7); 
		}

		private static void Student_Moving(object sender, MovingEventArgs e) // method for use event EventHandler
		{
			Console.WriteLine(e.Message);
		}
		/*
		// method for delegate, only show parametr "message"
		static void Show (string message) 
		{
			Console.WriteLine(message);
		}
		*/
	}
}
