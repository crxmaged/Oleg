using System;

namespace SoloLearnSocialNetwork.Folder
{
	class Post
	{ // SoloLearn number 3
		private string text;

		public Post()
		{
			text = "New post\n";
		}

		public void ShowPost()
		{
			Console.WriteLine(text);
		}

		public string Text
		{
			get { return text; }
			set { text = text + value; }
		}
	}
}
