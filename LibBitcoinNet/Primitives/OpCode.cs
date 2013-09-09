using System;
using System.Collections.Generic;

namespace LibBitcoinNet.Primitives
{
	public enum OpCode
	{
		Zero = 0,
		Special = 1,
		PushData1 = 76,
		PushData2 = 77,
		PushData4 = 78,
		Negative1 = 79,
		Reserved = 80,
		Op1 = 81,
		Op2 = 82,
		Op3 = 83,
		Op4 = 84,
		Op5 = 85,
		Op6 = 86,
		Op7 = 87,
		Op8 = 88,
		Op9 = 89,
		Op10 = 90,
		Op11 = 91,
		Op12 = 92,
		Op13 = 93,
		Op14 = 94,
		Op15 = 95,
		Op16 = 96,
		Nop = 97,
		Ver = 98,
		If = 99,
		NotIf = 100,
		VerIf = 101,
		VerNotIf = 102,
		Else = 103,
		EndIf = 104,
		Verify = 105,
		Return = 106,
		ToAltStack = 107,
		FromAltStack = 108,
		Op2Drop = 109,
		Op2Dup = 110,
		Op3Dup = 111,
		Op2Over = 112,
		Op2Rot = 113,
		Op2Swap = 114,
		IfDup = 115,
		Height = 116,
		Drop = 117,
		Dup = 118,
		Nip = 119,
		Over = 120,
		Pick = 121,
		Roll = 122,
		Rot = 123,
		Swap = 124,
		Tuck = 125,
		Cat = 126,
		SubStr = 127,
		Left = 128,
		Right = 129,
		Size = 130,
		Invert = 131,
		And = 132,
		Or = 133,
		Xor = 134,
		Equal = 135,
		EqualVerify = 136,
		Reserved1 = 137,
		Reserved2 = 138,
		Op1Add = 139,
		Op1Sub = 140,
		Op2Mul = 141,
		Op2Div = 142,
		Negate = 143,
		Abs = 144,
		Not = 145, 
		Op0NotEqual = 146,
		Add = 147,
		Sub = 148,
		Mul = 149,
		Div = 150,
		Mod = 151,
		LShift = 152,
		RShift = 153,
		BoolAnd = 154,
		BoolOr = 155,
		NumEqual = 156,
		NumEqualVerify = 157,
		NumNotEqual = 158,
		LessThan = 159,
		GreaterThan = 160,
		LessThanOrEqual = 161,
		GreaterThanOrEqual = 162,
		Min = 163,
		Max = 164,
		Within = 165,
		RipeMd160 = 166,
		Sha1 = 167,
		Sha256 = 168,
		Hash160 = 169,
		Hash256 = 170,
		CodeSeparator = 171,
		CheckSig = 172,
		CheckSigVerify = 173,
		CheckMultiSig = 174,
		CheckMultiSigVerify = 175,
		OpNop1 = 176,
		OpNop2 = 177,
		OpNop3 = 178,
		OpNop4 = 179,
		OpNop5 = 180,
		OpNop6 = 181,
		OpNop7 = 182,
		OpNop8 = 183,
		OpNop9 = 184,
		OpNop10 = 185,
		BadOperation,
		RawData
	}
}