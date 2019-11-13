using System;
using SetObjectToMethod.classStore;

namespace SetObjectToMethod
{
	class Program
	{
		static void Main(string[] args)
		{
			UserClass user1 = new UserClass(1, 10);
			UserClass user2 = new UserClass(22, 33);

			Console.WriteLine("Are the object {0}, are same {1}? ans: {2}", nameof(user1), nameof(user2), user1.AsSame(user2));
			user1.Show();
			user2.Show();
			Console.WriteLine("Value object user2 to object user1");
			user1.Copy(user2);
			user1.Show();
			user2.Show();
			Console.WriteLine("Are the object {0}, are same {1}? ans: {2}", nameof(user1), nameof(user2), user1.AsSame(user2));

			Console.ReadLine();
		}
	}
}
