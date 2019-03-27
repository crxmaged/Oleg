using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
	class WorkModul
	{
		string newText;
		public string ModText (string oldtext)
		{
			newText = oldtext + " have a nice life!";
			return newText;
		}
	}
}
