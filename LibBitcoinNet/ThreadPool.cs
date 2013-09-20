using System;
using System.Runtime.InteropServices;
using LibBitcoinNet.Interfaces;

namespace LibBitcoinNet
{
	public class ThreadPool : BaseNativeClass
	{
		public ThreadPool(UInt32 numThreads)
		{
			NativeObject = CreateThreadPool(numThreads);
		}

		#region implemented abstract members of LibBitcoinNet.BaseNativeClass

		protected override void DisposeClass()
		{
			DisposeThreadPool(NativeObject);
		}

		#endregion

		#region InterOp

		[DllImport("libbitcoin.so", EntryPoint = "create_threadpool", CallingConvention = CallingConvention.Cdecl)]
		protected static extern IntPtr CreateThreadPool(UInt32 numThreads);

		[DllImport("libbitcoin.so", EntryPoint = "dispose_threadpool")]
		protected static extern void DisposeThreadPool(IntPtr pool);

		#endregion
	}
}