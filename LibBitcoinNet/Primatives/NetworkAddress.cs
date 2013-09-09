using System;

namespace LibBitcoinNet.Primatives
{
	public struct NetworkAddress
	{
		public UInt32 TimeStamp;
		public UInt64 Services;
		public byte[] Ip;
		public UInt16 port;
	}
}