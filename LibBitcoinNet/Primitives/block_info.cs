using System;
using System.Runtime.InteropServices;

namespace LibBitcoinNet.Primitives
{
	public enum block_status
	{
		orphan,
		confirmed,
		rejected
	}

	[StructLayout(LayoutKind.Sequential)]
	public struct block_info
	{
		block_status status;
		UInt32 height;
	}
}

