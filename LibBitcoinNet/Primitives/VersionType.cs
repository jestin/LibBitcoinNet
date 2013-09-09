using System;

namespace LibBitcoinNet.Primitives
{
	public struct VersionType
	{
		public UInt32 Version;
		public UInt64 Services;
		public UInt64 Timestamp;
		public NetworkAddress AddressMe;
		public NetworkAddress AddressYou;
		public UInt64 Nonce;
		public string UserAgent;
		public UInt32 StartHeight;
	}
}