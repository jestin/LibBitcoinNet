using System;
using System.Runtime.InteropServices;

namespace LibBitcoinNet.Primitives
{
	[StructLayout(LayoutKind.Sequential)]
	public struct header_type
	{
		public UInt32 magic;
		public string command;
		public UInt32 payload_length;
		public UInt32 checksum;
	}
}