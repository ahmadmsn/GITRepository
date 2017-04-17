using System;
using System.Collections.Generic;
using System.Text;
class multidimexample
{
	static void Main()
	{
		int sum=0;
		int rowsum;
		int[ , ] marray=new int[2,4]
		{
			{2,2,2,2},
			{3,3,3,3},
		};
		for(int row=0;row<2;row++)
		{
			rowsum=0;
			for(int col=0;col<4;col++)
			{
				Console.Write("{0}\t",marray[row,col]);
				rowsum=rowsum+marray[row,col];
			}
			sum=sum+rowsum;
			Console.Write("={0}",rowsum);
			Console.WriteLine();
		}
		Console.WriteLine(" The Sum of the array Is:{0}",sum);
	}
	
	
}

		