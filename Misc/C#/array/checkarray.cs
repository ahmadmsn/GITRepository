using System;
class checkarray
{
	public static void Main()
	{
		int [] abc=new int[6];
		for(int i=0;i<5;i++)
		{
			abc[i]=i+1;
			//Console.WriteLine(abc[i]);
			
		}
		foreach (int j in abc)
		{
			Console.WriteLine(abc[j]);
		}
	}
}