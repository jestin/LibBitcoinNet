using System;
using LibBitcoinNet.Interfaces;

namespace LibBitcoinNet
{
	public abstract class BaseNativeClass : INativeClass, IDisposable
	{
		#region INativeClass implementation

		public IntPtr NativeObject { get; set; }

		#endregion

		#region Destructor

		~BaseNativeClass()
		{
			Dispose();
		}

		#endregion

		#region IDisposable implementation

		public void Dispose()
		{
			Dispose(true);
		}

		#endregion

		protected virtual void Dispose(bool disposing)
		{
			if(NativeObject != IntPtr.Zero)
			{
				DisposeClass();
				NativeObject = IntPtr.Zero;
			}

			if(disposing)
			{
				GC.SuppressFinalize(this);
			}
		}

		protected abstract void DisposeClass();
	}
}

