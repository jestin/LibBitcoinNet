using System;

namespace LibBitcoinNet.Primatives
{
	public struct Header
	{
		public UInt32 Magic;
		public string Command;
		public UInt32 PayloadLength;
		public UInt32 Checksum;
	}
}