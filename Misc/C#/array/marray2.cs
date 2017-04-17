using System;
using System.Collections.Generic;
//using System.Text;
class marray2
{
	public static void Main()
	{
		int sum=0;
		int rowsum;
		int cal;
		int [,] num=new int[2,5];
		
		for(int i=0;i<2;i++)
		{
			rowsum=0;
			for(int j=0;j<5;j++)
			{
				num[i,j]=j+1;
				
				Console.Write("{0} \t", num[i,j]);
				Array.Clear(num[i,j]);
				rowsum=rowsum+num[i,j];
				
			}
			
			Console.WriteLine(rowsum);
			sum=sum+rowsum;
			
		}
		Console.WriteLine("Total Sum Is "+sum);
		
		cal=num.Length;
		Console.WriteLine("Total Length Of Array Is {0}",cal);
		
		int ran=num.Rank;
		Console.WriteLine("Total Rank Of Array Is {0}",ran);	

		int t=num[0,4];
		Console.WriteLine(t);

		bool fix=num.IsFixedSize;
		Console.WriteLine(fix);

		bool read=num.IsReadOnly;
		Console.WriteLine(read);
	
		//int shorting = (int)num.Sort(5,3,2,4,1);
		//Console.WriteLine(shorting);
		
	
		
		

	}
}
				
