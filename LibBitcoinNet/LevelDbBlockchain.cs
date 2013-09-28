using System;
using System.Runtime.InteropServices;

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

		[DllImport("libbitcoin.so", EntryPoint = "dispose_leveldb_blockchain", CallingConvention = CallingConvention.Cdecl)]
		protected static extern void DisposeLevelDbBlockchain(IntPtr blockchain);

		#endregion
	}
}

