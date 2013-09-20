using System;
using System.Runtime.InteropServices;

namespace LibBitcoinNet
{
	public class DeterministicWallet : BaseNativeClass
	{
		#region Constructors

		public DeterministicWallet()
		{
			NativeObject = CreateDeterministicWallet();
		}

		#endregion

		#region Public Properties

		public string Seed
		{
			get { return CallSeed(NativeObject); }
		}

		#endregion

		#region Public Methods

		public void NewSeed()
		{
			CallNewSeed(NativeObject);
		}

		public bool SetSeed(string seed)
		{
			return CallSetSeed(NativeObject, seed);
		}

		public bool SetMasterPublicKey(byte[] mpk)
		{
			return CallSetMasterPublicKey(NativeObject, mpk);
		}

		public byte[] GeneratePublicKey(UInt32 n, bool forChange = false)
		{
			return CallGeneratePublicKey(NativeObject, n, forChange);
		}

		public byte[] GenerateSecret(UInt32 n, bool forChange = false)
		{
			return CallGenerateSecret(NativeObject, n, forChange);
		}

		#endregion

		#region implemented abstract members of LibBitcoinNet.BaseNativeClass

		protected override void DisposeClass()
		{
			DisposeDeterministicWallet(NativeObject);
		}

		#endregion

		#region InterOp

		[DllImport("libbitcoin.so", EntryPoint = "create_deterministic_wallet", CallingConvention = CallingConvention.Cdecl)]
		protected static extern IntPtr CreateDeterministicWallet();

		[DllImport("libbitcoin.so", EntryPoint = "call_deterministic_wallet_seed", CallingConvention = CallingConvention.Cdecl)]
		protected static extern string CallSeed(IntPtr wallet);

		[DllImport("libbitcoin.so", EntryPoint = "call_deterministic_wallet_new_seed", CallingConvention = CallingConvention.Cdecl)]
		protected static extern void CallNewSeed(IntPtr wallet);

		[DllImport("libbitcoin.so", EntryPoint = "call_deterministic_wallet_set_seed", CallingConvention = CallingConvention.Cdecl)]
		protected static extern bool CallSetSeed(IntPtr wallet, string seed);

		[DllImport("libbitcoin.so", EntryPoint = "call_deterministic_wallet_set_master_public_key", CallingConvention = CallingConvention.Cdecl)]
		protected static extern bool CallSetMasterPublicKey(IntPtr wallet, byte[] mpk);

		[DllImport("libbitcoin.so", EntryPoint = "call_deterministic_wallet_generate_public_key", CallingConvention = CallingConvention.Cdecl)]
		protected static extern byte[] CallGeneratePublicKey(IntPtr wallet, UInt32 n, bool forChange);

		[DllImport("libbitcoin.so", EntryPoint = "call_deterministic_wallet_generate_secret", CallingConvention = CallingConvention.Cdecl)]
		protected static extern byte[] CallGenerateSecret(IntPtr wallet, UInt32 n, bool forChange);

		[DllImport("libbitcoin.so", EntryPoint = "dispose_deterministic_wallet")]
		protected static extern void DisposeDeterministicWallet(IntPtr wallet);

		#endregion
	}
}

