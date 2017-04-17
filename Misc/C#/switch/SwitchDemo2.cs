using System;
class SwitchDemo2
{
	public static void Main()
	{
		char ch;
		for(ch='A';ch<='E';ch++)
		{
			switch(ch)
			{
				case 'A':
				Console.WriteLine("ch Is A");
				break;
	
				case 'B':
				Console.WriteLine("ch Is B");
				break;
				
				case 'C':
				Console.WriteLine("ch Is C");
				break;
			
				case 'D':
				Console.WriteLine("ch Is D");
				break;
	
				case 'E':
				Console.WriteLine("Ch Is E");
				break;
			}
		}
	}
}