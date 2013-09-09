using System;

namespace LibBitcoinNet.Primitives
{
	public struct Header
	{
		public UInt32 Magic;
		public string Command;
		public UInt32 PayloadLength;
		public UInt32 Checksum;
	}
}