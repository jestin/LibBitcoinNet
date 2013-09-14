using System;
using System.Runtime.InteropServices;

namespace LibBitcoinNet.Primitives
{
	[StructLayout(LayoutKind.Sequential)]
	public struct transaction_input_type
	{
		public output_point previous_output;
		public script_type script;
		public UInt32 sequence;
	}
}