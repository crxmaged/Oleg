using System;
using ShowStringTextInMirro.FolderWithClassWhereReplayceRextInMirrow;

namespace ShowStringTextInMirro
{
	class Program
	{
		static void Main(string[] args)
		{
			string sameText = "Test text for example!";
			Rext newText = new Rext();

			Console.WriteLine("Now we have text: {0}", sameText);

			Console.WriteLine("But we can change this! Use method 'Text' from class Rext!");
			newText.Text(sameText); // first show last element of text!

			Console.ReadLine();
		}
	}
}
