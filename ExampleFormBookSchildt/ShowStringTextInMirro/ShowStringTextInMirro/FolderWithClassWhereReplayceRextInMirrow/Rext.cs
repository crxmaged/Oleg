using System;

namespace ShowStringTextInMirro.FolderWithClassWhereReplayceRextInMirrow
{
	class Rext
	{
		public void Text (string text)
		{
			Console.WriteLine(); // break row
			if (text.Length > 0)
			{
				Console.WriteLine("{0}", text); // Show how to work!
				Text(text.Substring(1, text.Length - 1));
			}
			else
			{
				return;
			}
			Console.Write(text[0]);
		}
	}
}
