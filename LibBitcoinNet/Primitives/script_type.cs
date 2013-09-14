using System;
using System.Runtime.InteropServices;

namespace LibBitcoinNet.Primitives
{
	[StructLayout(LayoutKind.Sequential)]
	public struct operation
	{
		public opcode code;
		public IntPtr data;
	}

	public enum sighash
	{
		all = 1,
		none = 2,
		single = 3,
		anyone_can_pay = 0x80
	}

	public enum payment_type
	{
		pub_key,
		pub_key_hash,
		script_hash,
		multi_sig,
		pub_key_hash_sig,
		script_code_sig,
		non_standard
	}

	public class script_type
	{
		public void Join(script_type other)
		{
		}

		public void PushOperation(operation operation)
		{
		}

		public bool Run(script_type inputScript, transaction parentTrx, UInt32 inputIndex, bool Bip16Enabled=true)
		{
			return true;
		}

		public payment_type Type()
		{
			return payment_type.pub_key;
		}


	}
}