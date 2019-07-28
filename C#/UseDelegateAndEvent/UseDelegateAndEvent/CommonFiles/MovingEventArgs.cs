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

		}

		public MovingEventArgs(string message)
		{
			Message = message; 
		}

		public string Message { get; private set; }
	}
}
