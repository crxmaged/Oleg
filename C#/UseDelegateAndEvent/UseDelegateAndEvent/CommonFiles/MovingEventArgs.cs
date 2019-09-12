using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseDelegateAndEvent.CommonFiles
{ // use this class for event-parametr
	public class MovingEventArgs : EventArgs
	{
		public MovingEventArgs()
		{
			// default constructor
		}

		public MovingEventArgs(string message)
		{ // user constructor 
			Message = message; 
		}

		public string Message { get; private set; } // auto property
	}
}
