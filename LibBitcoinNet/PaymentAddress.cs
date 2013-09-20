using System;
using System.Runtime.InteropServices;

namespace LibBitcoinNet
{
	public class PaymentAddress : BaseNativeClass
	{
		#region Constructors

		public PaymentAddress()
		{
			NativeObject = CreatePaymentAddress();
		}

		public PaymentAddress(byte version, byte[] hash)
		{
			NativeObject = CreatePaymentAddress(version, hash);
		}

		public PaymentAddress(string encodedAddress)
		{
			NativeObject = CreatePaymentAddress(encodedAddress);
		}

		#endregion

		#region Members

		public void Set(byte version, byte[] hash)
		{
			PaymentAddressSet(NativeObject, version, hash);
		}

		public bool SetEncoded(string encodedAddress)
		{
			return PaymentAddressSetEncoded(NativeObject, encodedAddress);
		}

		#endregion

		#region Public Properties

		public byte Version
		{
			get { return PaymentAddressVersion(NativeObject); }
		}

		public byte[] Hash
		{
			get { return PaymentAddressHash(NativeObject); }
		}

		public string Encoded
		{
			get { return PaymentAddressEncoded(NativeObject); }
		}

		#endregion

		#region implemented abstract members of LibBitcoinNet.BaseNativeClass

		protected override void DisposeClass()
		{
			DisposePaymentAddress(NativeObject);
		}

		#endregion

		#region InterOp

		[DllImport("libbitcoin.so", EntryPoint = "create_payment_address", CallingConvention = CallingConvention.Cdecl)]
		protected static extern IntPtr CreatePaymentAddress();

		[DllImport("libbitcoin.so", EntryPoint = "create_payment_address_from_hash", CallingConvention = CallingConvention.Cdecl)]
		protected static extern IntPtr CreatePaymentAddress(byte version, byte[] hash);

		[DllImport("libbitcoin.so", EntryPoint = "create_payment_address_from_string", CallingConvention = CallingConvention.Cdecl)]
		protected static extern IntPtr CreatePaymentAddress(string encodedAddress);

		[DllImport("libbitcoin.so", EntryPoint = "call_payment_address_set", CallingConvention = CallingConvention.Cdecl)]
		protected static extern void PaymentAddressSet(IntPtr address, byte version, byte[] hash);

		[DllImport("libbitcoin.so", EntryPoint = "call_payment_address_set_encoded", CallingConvention = CallingConvention.Cdecl)]
		protected static extern bool PaymentAddressSetEncoded(IntPtr address, string encodedAddress);

		[DllImport("libbitcoin.so", EntryPoint = "call_payment_address_version", CallingConvention = CallingConvention.Cdecl)]
		protected static extern byte PaymentAddressVersion(IntPtr address);

		[DllImport("libbitcoin.so", EntryPoint = "call_payment_address_hash", CallingConvention = CallingConvention.Cdecl)]
		protected static extern byte[] PaymentAddressHash(IntPtr address);

		[DllImport("libbitcoin.so", EntryPoint = "call_payment_address_encoded", CallingConvention = CallingConvention.Cdecl)]
		protected static extern string PaymentAddressEncoded(IntPtr address);

		[DllImport("libbitcoin.so", EntryPoint = "dispose_payment_address")]
		protected static extern void DisposePaymentAddress(IntPtr address);

		#endregion
	}
}

