using System;
using System.Runtime.InteropServices;

namespace LibBitcoinNet.Primitives
{
	public enum inventory_type_id
	{
		error,
		transaction,
		block,
		none
	}

	[StructLayout(LayoutKind.Sequential)]
	public struct inventory_vector_type
	{
		public inventory_type_id type;
		public IntPtr hash_digest;
	}
}