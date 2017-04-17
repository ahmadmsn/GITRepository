using System;
class diffsizedim
{
	public static void Main()
	{

		int i,j;
		
		int [] [] x=new int [3] [];
		x[0]=new int[2];
		x[1]=new int[3];
		x[2]=new int[4];

		

		//int n1=x[0].Length;
		//Console.WriteLine(n1);
		
		for(j=0;j<3;j++)
		{
			int n=x[j].Length;
			Console.WriteLine(n);
			
			for(i=0;i<n;i++)
			{
				 x[j][i]=i+1;
				Console.Write(x[j][i]);
							
			}
			Console.WriteLine();
		}
	}

}