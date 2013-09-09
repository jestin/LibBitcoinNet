using System;

namespace LibBitcoinNet.Primitives
{
	public struct TransactionOutput
	{
		public UInt64 Value;
		public Script Script;
	}
}