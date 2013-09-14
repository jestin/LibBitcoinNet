using System;
using System.Runtime.InteropServices;

namespace LibBitcoinNet.Primitives
{
	[StructLayout(LayoutKind.Sequential)]
	public struct transaction
	{
		public UInt32 version;
		public UInt32 lock_time;
		public IntPtr inputs;
		public IntPtr outputs;
	}
}