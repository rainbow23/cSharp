using System;
using System.IO;

class ShowFile
{
	static void Main(string[] args)
	{
		int i;
		FileStream fin;
		
		if(args.Length != 1)
		{
			Console.WriteLine("Usage: ShowFlow File");
			return;
		}
		
		try
		{
			fin = new FileStream(args[0], FileMode.Open);
		}
		catch(IOException exc)
		{
			Console.WriteLine(exc.Message);
			return;
		}
	
		do 
		{
			try
			{
				i = fin.ReadByte();
			}
			catch(IOException exc)
			{
				Console.WriteLine(exc.Message);
				break;
			}

			if(i != -1) Console.WriteLine((char) i);		
		} while(i != -1);

		fin.Close();
	}	
}
