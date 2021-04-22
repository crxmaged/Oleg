using System;
using SoloLearnSocialNetwork.Folder;

namespace SoloLearnSocialNetwork
{
	class Program
	{ // SoloLearn number 3
		static void Main(string[] args)
		{
			string postText = Console.ReadLine();
			Post newPost = new Post();
			newPost.Text = postText;
			newPost.ShowPost();

			Console.ReadLine();
		}
	}
}
