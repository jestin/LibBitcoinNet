using System;
using System.Runtime.InteropServices;

namespace LibBitcoinNet.Primitives
{
	[StructLayout(LayoutKind.Sequential)]
	public struct get_blocks_type
	{
		public IntPtr start_hashes;
		public IntPtr hash_stop;
	}
}