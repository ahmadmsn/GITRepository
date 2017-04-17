using System;
class whiledemo
{
	public static void Main()
	{
		int num;
		int mag;
		
		num=435679;
		mag=0;
		Console.WriteLine("Number" +num);
		while(num>0)
		{
			num=num/10;
			mag++;
		};
		Console.WriteLine("Magnitude"+mag);
	}
}
	