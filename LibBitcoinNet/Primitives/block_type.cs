using System;
using System.Runtime.InteropServices;

namespace LibBitcoinNet.Primitives
{
	[StructLayout(LayoutKind.Sequential)]
	public struct block_type
	{
		public block_header_type header;
		public IntPtr transactions;
	}
}

