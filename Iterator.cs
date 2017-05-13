using System.Collections;
using System.Collections.Generic;
using System;

public class IteratorSample
{
	public static List <int> listInt ; 
	static public void Main()
	{

		listInt = new List <int>(){0,1,2,3,4,5};
/*
		//IEnumerator e = listInt.GetEnumerator(); 
		for(IEnumerator e = listInt.GetEnumerator(); e.MoveNext();)
		{
//			object obj = e.Current;
//			Console.WriteLine((int)obj);
		}	
*/		
		Test();
	}

	private static void Test()
	{
		//for(listInt = new List <int>(){0,1,2,3,4,5}; HasNext();)

		int i=0;
		for(; HasNext();)
		{
			i++;
			Console.WriteLine(i);
/*
			IEnumerator e = listInt.GetEnumerator();
			object obj = e.Current;
			Console.WriteLine((int)obj);
			e.MoveNext();
*/
		}

	}
	
	private static int num=0;	
	private static bool HasNext()
	{
		if(num < 8)
		{
			num++;
			return true;
		}

		return false;
/*
		IEnumerator e = listInt.GetEnumerator();
		return e.MoveNext();
*/ 
	}

}
