using System;
class demo12
{
	public static void Main()
	{
		int [] d1=new int[5];
		d1[0]=5;
		d1[1]=10;
		d1[2]=15;
		for(int i=0;i<d1.Length;i++)
		{
			int x=d1[i];
			Console.WriteLine(x);
		}
		//indexerdemo1 d1=new indexerdemo1();
		
		//Console.WriteLine("Value of d1,d2,d3 {0},{1},{2}",d1[0],d1[1],d1[2]);
	}
}