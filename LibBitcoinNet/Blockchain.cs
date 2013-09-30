using System;
using System.Runtime.InteropServices;
using LibBitcoinNet.Primitives;

namespace LibBitcoinNet
{
	public abstract class Blockchain : BaseNativeClass
	{
		#region Delegates

		public delegate double StoreBlockHandler(IntPtr errorCode, block_info blockInfo);
		public delegate void StartHandler(IntPtr errorCode);
		public delegate void ImportBlockHandler(IntPtr errorCode);

		#endregion
	}
}

