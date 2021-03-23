using System;

namespace UserStruct.Folder
{
	class Operation
	{
		static uint NumberTransaction = 0; // use this variable with struct, have to use 'static'
		InfoOperations PacketTrans; // use User stuct type
		string IdeTrans;
		double MoneySize;

		public Operation ()
		{
			// default constructor
		}

		public Operation(string definitonIde, double mountMoney)
		{ // construct with two param
			IdeTrans = definitonIde;
			MoneySize = mountMoney;
			PacketTrans.NumberPacketge = NumberTransaction++;
			PacketTrans.SizePacketge = 512;
		}

		public void ShowTrasation()
		{
			Console.WriteLine("Current number packetge: {0} \n Size: {1} \n Ide Transaction: {2} \n How much money {3}", PacketTrans.NumberPacketge, PacketTrans.SizePacketge, IdeTrans, MoneySize);
		}
	}
}
