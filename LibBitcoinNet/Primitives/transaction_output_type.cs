using System;
using System.Runtime.InteropServices;

namespace LibBitcoinNet.Primitives
{
	[StructLayout(LayoutKind.Sequential)]
	public struct transaction_output_type
	{
		public UInt64 value;
		public script_type script;
	}
}