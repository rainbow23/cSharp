using System;

class ShowBits
{
	private int numberbits;

	public ShowBits(int n)
	{
		numberbits = n;
	}

	public void Show(ulong val)
	{
		ulong mask =1;
		mask <<= numberbits - 1;
	
		int separator = 0;	
		for(; mask > 0;  mask >>= 1)
		{
			if((val & mask) != 0)
			{
				Console.Write(" 1");	
			}
			else
			{
				Console.Write(" 0");	
			}

			separator += 1;

			if((separator % 8) == 0)
			{
				Console.Write(" ");
				separator = 0; 
			}
		}

		Console.WriteLine();	
	}	
}


class ShowBitsDemo
{
	static void Main(string [] args)
	{
		ShowBits sb1 = new ShowBits(8);
		ShowBits sb2 = new ShowBits(16);
		ShowBits sb3 = new ShowBits(32);
		ShowBits sb4 = new ShowBits(64);

		sb1.Show(123);	
		sb2.Show(123);	
		sb3.Show(123);	
		sb4.Show(123);	
		//sb2.Show(456);	
		//sb3.Show(789);	
	}

}

