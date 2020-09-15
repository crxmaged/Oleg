using System;

namespace WorkWithProperty.SomeClass
{
	class PublicClassWithSimpleProperty
	{
		private int age;

		public PublicClassWithSimpleProperty () { age = 33; }

		public int MyProp
		{
			get
			{
				return age;
			}
			private set
			{
				age = value;
			}
		}

		public void IncrProp()
		{
			age = ++age;
		}
	}
}
