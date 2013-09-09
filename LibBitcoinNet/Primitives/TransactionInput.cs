using System;

namespace LibBitcoinNet.Primitives
{
	public struct TransactionInput
	{
		public OutputPoint PreviousOutput;
		public Script Script;
		public UInt32 Sequence;
	}
}