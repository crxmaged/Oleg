using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SimpleEvent.Common
{
	public delegate void ShowMessage(string message);

	public class Student
	{
		public void Move (int distance)
		{
			for (int i = 0; i <= distance; i++)
			{
				Thread.Sleep(1000);
				if (Moving != null)
				{
					Moving (this, new Mov)
				}
			}
		}

		public event EventHandler<> Moving();
	}
}
