using System;

namespace Property.FolderWithClass
{
	class ClassWithClass
	{
		private int prop; // private field
		
		public ClassWithClass () // default constructor
		{
			prop = 0;
		}

		public int Prop // Use Property - Prop for field prop
		{
			get
			{ // use method in property - can take value of field prop
				return prop;
			}

			set
			{ // setupe value for field with checkpoint
				if (value >= 0) // if value is positive
				{
					prop = value;
				}
			}
		}
	}
}
