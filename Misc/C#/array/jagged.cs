using System;
class jagged
{
	public static void Main()
	{
		int [] [] jagged=new int[3][];
		jagged[0]=new int[4];
		jagged[1]=new int[5];
		jagged[2]=new int[7];
		int i;
		for(i=0;i<3;i++)
		{
			jagged[0][i]=i+1;
			Console.Write(jagged[0][i]);
		}
		Console.WriteLine("");
		for(i=0;i<4;i++)
		{
			jagged[1][i]=i+1;
			Console.Write(jagged[1][i]);
		}
		Console.WriteLine();
		for(i=0;i<7;i++)
		{
			jagged[2][i]=i;
		}
		for(i=0;i<7;i++)
		{
			Console.Write(jagged[2][i]);
		}
	}
}
			