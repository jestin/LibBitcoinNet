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
		public static extern UInt64 block_value(UInt32 height);

		[DllImport("libbitcoin.so", EntryPoint = "hash_block_header")]
		[return: MarshalAs(UnmanagedType.Struct)]
		public static extern byte[] hash_block_header(ref block_header_type header); 

		//*************************************************************
		// Test call that doesn't actuall exist in libbitcoin
		//*************************************************************
		[DllImport("libbitcoin.so", EntryPoint = "pinvoke_test", CallingConvention = CallingConvention.Cdecl)]
		public static extern void pinvoke_test();
		//*************************************************************
	}
}

