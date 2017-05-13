using System;

public class DelegateSample
{
	delegate void CountIt(int end);

	public static void Main()
	{
		int varInMain = 100;

		CountIt count = delegate(int end)
		{
			for(int i=0; i<end; i++)
			{
				Console.Write(i + " ");
			}
			Console.Write("varInMain " +  varInMain); 
		};

		count(3);
		Console.WriteLine("");
		count(10);
		Console.WriteLine("");
	}

}
