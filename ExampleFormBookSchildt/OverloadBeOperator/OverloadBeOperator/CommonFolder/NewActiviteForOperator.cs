using System;

namespace OverloadBeOperator.CommonFolder
{
	class NewActiviteForOperator
	{
		int x, y, z;

		public NewActiviteForOperator()
		{
			x = y = z = 0;
		}

		public NewActiviteForOperator(int x, int y, int z)
		{
			this.x = x;
			this.y = y;
			this.z = z;
		}

		static public NewActiviteForOperator operator + (NewActiviteForOperator leftOperator, NewActiviteForOperator rightOperator)
		{
			NewActiviteForOperator result = new NewActiviteForOperator();

			result.x = leftOperator.x + rightOperator.x;
			result.y = leftOperator.y + rightOperator.y;
			result.z = leftOperator.z + rightOperator.z;

			return result;
		}

		static public NewActiviteForOperator operator - (NewActiviteForOperator leftOperator, NewActiviteForOperator rightOperator)
		{
			NewActiviteForOperator result = new NewActiviteForOperator();

			result.x = leftOperator.x - rightOperator.x;
			result.y = leftOperator.y - rightOperator.y;
			result.z = leftOperator.z - rightOperator.z;

			return result;
		}

		public void ShowCurrentValue ()
		{
			Console.WriteLine("x: {0}, y: {1}, z: {2}", x, y, z);
		}
	}
}
