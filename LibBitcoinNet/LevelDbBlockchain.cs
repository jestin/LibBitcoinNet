using System;
using System.Runtime.InteropServices;
using LibBitcoinNet.Primitives;

namespace LibBitcoinNet
{
	public class LevelDbBlockchain : Blockchain
	{
		#region Constructors

		public LevelDbBlockchain(ThreadPool pool)
		{
			NativeObject = CreateLevelDbBlockchain(pool.NativeObject);
		}

		#endregion

		#region Memebers

		public void Start(string prefix, StartHandler handler)
		{
			CallLevelDbBlockchainStart(NativeObject, prefix, handler);
		}

		public void Stop()
		{
			CallLevelDbBlockchainStop(NativeObject);
		}

		public void Store(block_type block, StoreBlockHandler handler)
		{
			CallLevelDbBlockchainStore(NativeObject, block, handler);
		}

		public void Import(block_type block, UInt32 height, ImportBlockHandler handler)
		{
			CallLevelDbBlockchainImport(NativeObject, block, height, handler);
		}

		#endregion

		#region implemented abstract members of LibBitcoinNet.BaseNativeClass

		protected override void DisposeClass()
		{
			DisposeLevelDbBlockchain(NativeObject);
		}

		#endregion

		#region InterOp

		[DllImport("libbitcoin.so", EntryPoint = "create_leveldb_blockchain", CallingConvention = CallingConvention.Cdecl)]
		protected static extern IntPtr CreateLevelDbBlockchain(IntPtr pool);

		[DllImport("libbitcoin.so", EntryPoint = "call_leveldb_blockchain_start", CallingConvention = CallingConvention.Cdecl)]
		protected static extern void CallLevelDbBlockchainStart(IntPtr blockchain, string prefix, StartHandler handler);

		[DllImport("libbitcoin.so", EntryPoint = "call_leveldb_blockchain_stop", CallingConvention = CallingConvention.Cdecl)]
		protected static extern void CallLevelDbBlockchainStop(IntPtr blockchain);

		[DllImport("libbitcoin.so", EntryPoint = "call_leveldb_blockchain_store", CallingConvention = CallingConvention.Cdecl)]
		protected static extern void CallLevelDbBlockchainStore(IntPtr blockchain, block_type block, StoreBlockHandler handler);

		[DllImport("libbitcoin.so", EntryPoint = "call_leveldb_blockchain_import", CallingConvention = CallingConvention.Cdecl)]
		protected static extern void CallLevelDbBlockchainImport(IntPtr blockchain, block_type block, UInt32 height, ImportBlockHandler handler);

		[DllImport("libbitcoin.so", EntryPoint = "dispose_leveldb_blockchain", CallingConvention = CallingConvention.Cdecl)]
		protected static extern void DisposeLevelDbBlockchain(IntPtr blockchain);

		#endregion
	}
}

