using System;

namespace HidingFieldforBaseClass.CommonFolder
{
	class InheritanceClass : BaseClass
	{
		new int i; // this field hiding anothe field from BaseClass
		public InheritanceClass()
		{
			i = 0;
		}

		public InheritanceClass (int i)
		{
			this.i = i;
		}

		public void Show()
		{
			Console.WriteLine("Field i have value: {0}", i);
		}

		public void ShowBase()
		{ // show value i variable from base class
			Console.WriteLine("Field from base class have value: {0}", base.i);
		}
	}
}
