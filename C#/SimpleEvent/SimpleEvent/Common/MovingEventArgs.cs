using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleEvent.Common
{
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
