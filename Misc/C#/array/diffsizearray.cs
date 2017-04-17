using System;
class diffsizearray
{
	public static void Main()
	{
		int [] [] x=new int [3] [];
		x[0]=new int[2];
		x[1]=new int[3];
		x[2]=new int[4];

		int n=x.Length;
		Console.WriteLine(n);
		
		int m=x[0].Length;
		Console.WriteLine(m);
		//for(int l=0;l
		
		for(int i=0;i<3;i++)
		{
			for(int j=0;j<4;j++)
			{
				x[i,j]=j+1;
				Console.Write(" "+x[i,j]);
			}
		}
	}
}
