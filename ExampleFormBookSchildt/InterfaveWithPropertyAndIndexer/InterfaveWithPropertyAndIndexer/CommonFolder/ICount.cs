using System;

namespace InterfaveWithPropertyAndIndexer.CommonFolder
{
	interface ICount
	{ // page 386
		int GetNumber
		{ // property in interface
			get;
			set;
		}

		int this[int index]
		{ // indexer in indexer
			get;
		}
	}
}
