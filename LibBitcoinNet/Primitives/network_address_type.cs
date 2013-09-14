using System;
using System.Runtime.InteropServices;

namespace LibBitcoinNet.Primitives
{
	[StructLayout(LayoutKind.Sequential)]
	public struct network_address_type
	{
		public UInt32 timestamp;
		public UInt64 services;
		public IntPtr ip;
		public UInt16 port;
	}
}