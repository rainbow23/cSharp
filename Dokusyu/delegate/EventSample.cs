using System;

delegate void MyEventHandler ();

class EventSample
{
	public event MyEventHandler someEvent;
	public void Fire()
	{
		if(someEvent != null)
		{
			someEvent();
		}
	}
}

class EventDemo
{
	static void Handler()
	{
		Console.WriteLine("Event Occured");
	}

	public static void Main()
	{
		EventSample eventSample = new EventSample(); 
		eventSample.someEvent += Handler;
		eventSample.Fire();
	}

}
