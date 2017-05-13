using System;

class PwrOfTwo
{
	public int this[int index]
	{
		get
		{
			if((index >= 0) && (index <16)) return Pwr(index);
			else return -1;
		}
	}

	int Pwr(int p)
	{
		int result = 1;
		
		for(int i = 0; i < p; i++)
		{
			result *= 2;
		}
		
		return result;
	}
}

class UsePwrOfTwo
{
	public static void Main(string[] args)
	{
		PwrOfTwo pwr = new PwrOfTwo();
		Console.Write("First 8 Power of Two ");
		
		for(int i=0; i<8; i++)
		{
			Console.WriteLine(pwr[i] + " ");
		}

		Console.WriteLine("1*2 " + (1*2) );
	}

}
