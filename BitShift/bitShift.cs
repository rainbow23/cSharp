using System;

[FlagsAttribute]
enum PermissionFlags
{
	None   = 0,
	Read   = 1,
	Create = 1 << 1,
	Write  = 1 << 2,
	Delete = 1 << 3,
	All    = 1 | 1 << 1 | 1 << 2 | 1 << 3 
}

class BitShift
{
	
	static public void Main (string[] args)
	{
		int num = 10;
		num = num << 1;

		string nString = Convert.ToString(num);
		nString = nString.PadLeft(4, '0');
		Console.WriteLine("num {0}", nString);

		int flag2 = 2;//0010
		int flag3 = 3;//0011
		int flag4 = 4;//0100
		Console.WriteLine(flag2 & 2);//2
		Console.WriteLine(flag3 & 2);//2

		int ret  = flag3 | flag4;
	
		string retString = Convert.ToString(ret,2).PadLeft(4, '0');
		Console.WriteLine("{0} | {1} = {2}", flag3, flag4, retString);

		int ret2 = flag2 | flag3;
		//string ret2String = Convert.ToString(ret2, 2);
		Console.WriteLine("{0} | {1} = {2}", Convert.ToString(flag2, 2),
											Convert.ToString(flag3, 2),
											Convert.ToString(ret2, 2).PadLeft(4, '0')
											);
		//Console.WriteLine("ret2String {0}", ret2String.PadLeft(4, '0'));
		Console.WriteLine();

		int flag5 = 5;
		int xor = (byte)~flag2;

		Console.WriteLine("xor {0}", xor);//253
		//xor = ~flag2;
		//Console.WriteLine("xor {0}", xor);//-3

		Console.WriteLine("flag2 {0}", Convert.ToString(flag2, 2).PadLeft(4, '0'));
		//0010
		Console.WriteLine("xor   {0}", Convert.ToString(xor, 2).PadLeft(4, '0'));
		//(byte)でキャストした場合   11111101
		//11111111111111111111111111111101

		int all = 1 | 1 << 1 | 1 << 2 | 1 << 3 ;
		Console.WriteLine("all {0}", Convert.ToString(all, 2).PadLeft(4, '0'));

		Console.WriteLine();

		PermissionFlags p = PermissionFlags.Create | PermissionFlags.Write;

		Console.WriteLine(p); //Create, Write

		//get
		Console.WriteLine(p & PermissionFlags.Create);//Create
		
		//add
		p |= PermissionFlags.Delete; 
		Console.WriteLine(p);//Create, Write, Delete

		//delete
		p &= ~PermissionFlags.Create;
		Console.WriteLine(p);//Write, Delete
	}
}

