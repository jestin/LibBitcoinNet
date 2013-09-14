using System;
using LibBitcoinNet.Primitives;
using System.Runtime.InteropServices;

namespace LibBitcoinNet
{
	public class Interop
	{
		[DllImport("libbitcoin.so", EntryPoint = "_ZN10libbitcoin13genesis_blockEv")]
		public static extern block_type genesis_block();
	}
}

