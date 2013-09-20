using System;
using LibBitcoinNet;
using LibBitcoinNet.Primitives;

namespace LibBitCoinSample
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			//Interop.pinvoke_test();
			//var test = Interop.genesis_block();

			for(uint i = 209990; i < 210010; i++)
			{
				Console.WriteLine("{0}", Interop.block_value(i));
			}

			//var threadPool = new ThreadPool(5);

			//var address = new PaymentAddress(2, new byte[]{ 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 });
			//var address = new PaymentAddress("something");

			var wallet = new DeterministicWallet();
		}
	}
}
