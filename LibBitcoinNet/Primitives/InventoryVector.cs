using System;

namespace LibBitcoinNet.Primitives
{
	public enum InventoryTypeId
	{
		Error,
		Transaction,
		block,
		none
	}

	public struct InventoryVector
	{
		public InventoryTypeId Type;
		public byte[] HashDigest;
	}
}