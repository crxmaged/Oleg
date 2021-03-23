using System;

namespace UseEnumForPlant
{
	class Control
	{ // page 400
		public enum WorkStages { Start, Continue, Pause, Restart, Stop, End, Undefined };
		// use enum for convenient creat user simple types
		public void Request(WorkStages toDo)
		{ // now can use user types in switch to show what stage plant work 
			switch (toDo)
			{
				case WorkStages.Start:
					{
						Console.WriteLine("Start work conveyor!");
						break;
					}
				case WorkStages.Continue:
					{
						Console.WriteLine("Continue work conveyor!");
						break;
					}
				case WorkStages.Pause:
					{
						Console.WriteLine("Pause one part of conveyor");
						break;
					}
				case WorkStages.Restart:
					{
						Console.WriteLine("Restart work conveyor at stage: ");
						break;
					}
				case WorkStages.Stop:
					{
						Console.WriteLine("Stop work conveyor and wait what to do else!");
						break;
					}
				case WorkStages.End:
					{
						Console.WriteLine("End work conveyor!");
						break;
					}
				default:
					{
						Console.WriteLine("Wait for request!");
						break;
					}
			}
		}

		static void Main(string[] args)
		{
			Control UserControl = new Control();
			// simple work with enum in this programz
			UserControl.Request(WorkStages.Start);
			UserControl.Request(WorkStages.Pause);
			UserControl.Request(WorkStages.Continue);
			UserControl.Request(WorkStages.End);
			UserControl.Request(WorkStages.Undefined);

			Console.ReadLine();
		}
	}
}
