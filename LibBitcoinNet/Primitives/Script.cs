using System;
using System.Collections.Generic;

namespace LibBitcoinNet.Primitives
{
	public struct Operation
	{
		public OpCode Code;
		public ICollection<byte[]> Data;
	}

	public enum SigHash
	{
		All = 1,
		None = 2,
		Single = 3,
		AnyoneCanPay = 0x80
	}

	public enum PaymentType
	{
		PubKey,
		PubKeyHash,
		ScriptHash,
		MultiSig,
		PubKeyHashSig,
		ScriptCodeSig,
		NonStandard
	}

	public class Script
	{
		public void Join(Script other)
		{
		}

		public void PushOperation(Operation operation)
		{
		}

		public bool Run(Script inputScript, Transaction parentTrx, UInt32 inputIndex, bool Bip16Enabled=true)
		{
			return true;
		}

		public PaymentType Type()
		{
			return PaymentType.PubKey;
		}


	}
}