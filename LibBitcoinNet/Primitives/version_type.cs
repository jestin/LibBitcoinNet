using System;
using System.Runtime.InteropServices;

namespace LibBitcoinNet.Primitives
{
	[StructLayout(LayoutKind.Sequential)]
	public struct version_type
	{
		public UInt32 version;
		public UInt64 services;
		public UInt64 timestamp;
		public network_address_type address_me;
		public network_address_type address_you;
		public UInt64 nonce;
		public string user_agent;
		public UInt32 start_height;
	}
}