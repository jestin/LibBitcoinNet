using System;
using LibBitcoinNet.Primitives;
using System.Runtime.InteropServices;

namespace LibBitcoinNet
{
	public class Interop
	{
		[DllImport("libbitcoin.so", EntryPoint = "genesis_block")]
		[return: MarshalAs(UnmanagedType.Struct)]
		public static extern block_type genesis_block();

		[DllImport("libbitcoin.so", EntryPoint = "block_value")]
		[return: MarshalAs(UnmanagedType.Struct)]
		public static extern UInt64 block_value(UInt32 height);

		[DllImport("libbitcoin.so", EntryPoint = "pinvoke_test")]
		public static extern void pinvoke_test();
	}
}

