using System;
class SwitchDemo
{
	public static void Main()
	{
		int i;
		for(i=0;i<10;i++)
		{
			switch(i)
			{
				case 0:
				Console.WriteLine("i Is zero");
				break;
			
				case 1:
				Console.WriteLine("i Is One");
				break;

				case 2:
				Console.WriteLine("i is two");
				break;
	
				case 3:
				Console.WriteLine("i is Three");
				break;

				default :
				Console.WriteLine("i is four or more");
				break;
			}
		}
	}
}				
	