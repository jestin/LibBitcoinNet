using System;
using System.Collections.Generic;

namespace LibBitcoinNet.Primitives
{
	public struct Transaction
	{
		public UInt32 Version;
		public UInt32 LockTime;
		public ICollection<TransactionInput> Inputs;
		public ICollection<TransactionOutput> Outputs;
	}
}