using System;
using LibBitcoinNet;

namespace LibBitCoinSample
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			var genesisBlock = Interop.genesis_block();
		}
	}
}
