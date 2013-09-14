using System;
using System.Runtime.InteropServices;

namespace LibBitcoinNet.Primitives
{
	[StructLayout(LayoutKind.Sequential)]
	public struct output_point
	{
		public IntPtr hash;
		public UInt32 index;
	}
}