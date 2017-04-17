using System;
class array1
{
	public static void Main()
	{
		int [] number =new int[10];
		//int n=number.length;
		/*for(int i=0;i<5;i++)
		{
			number[i]=i+5;
			//Console.WriteLine(number[i]);
		}*/
		foreach(int j in number)
		{	
			
			Console.WriteLine(number[j]);
		}
	}
}