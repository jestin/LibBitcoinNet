using System;
using System.Collections.Generic;

namespace LibBitcoinNet.Primitives
{
	public struct GetBlocks
	{
		public ICollection<byte[]> StartHashes;
		public byte[] HashStop;
	}
}