using System;
using LibBitcoinNet;

namespace LibBitCoinSample
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			//Interop.pinvoke_test();
			//var test = Interop.genesis_block();

			for(uint i = 258500; i < 258560; i++)
			{
				Console.WriteLine("{0}", Interop.block_value(i));
			}
		}
	}
}
