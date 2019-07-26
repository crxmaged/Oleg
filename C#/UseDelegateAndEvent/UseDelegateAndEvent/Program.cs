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
			Studet student = new Studet();
			// give to delegate method Show and check it
			ShowMessage method = Show;
			// set count step for student
			student.Move(7, method);
		}
		// method for delegate
		static void Show (string message) 
		{
			Console.WriteLine(message);
		}
	}
}
