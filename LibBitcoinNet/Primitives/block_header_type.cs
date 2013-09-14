using System;
using System.Runtime.InteropServices;

namespace LibBitcoinNet.Primitives
{
	[StructLayout(LayoutKind.Sequential)]
	public struct block_header_type
	{
		public UInt32 version;
		public IntPtr previous_block_hash;
		public IntPtr merkle;
		public UInt32 timestamp;
		public UInt32 bits;
		public UInt32 nonce;
	}
}

