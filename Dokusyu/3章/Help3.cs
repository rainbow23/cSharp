using System;

class Help3
{
	static void Main()
	{
		char choice;
		for(;;)
		{
			do
			{
				Console.WriteLine("Help on:");
				Console.WriteLine(" 1. if");
				Console.WriteLine(" 2. switch");
				Console.WriteLine(" 3. for");
				Console.WriteLine(" 4. while");
				Console.WriteLine(" 5. do-while");
				Console.WriteLine(" 6. break");
				Console.WriteLine(" 7. continue");
				Console.WriteLine(" 8. goto\n");
				Console.WriteLine("Choose one (q to quit): ");
				do
				{
					choice = (char)Console.Read();
				} while(choice == '\n' | choice == '\r');
			} while(choice < '1' | choice > '8' & choice != 'q');

			if(choice == 'q')break;
			
			Console.WriteLine("choice " + choice);
			Console.WriteLine("\n");
		}
	}
}
