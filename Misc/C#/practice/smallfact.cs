using System;
class smallfact
{
	public static void Main()
	{
		int i,j;
		//int k;
		Console.WriteLine("ENTER NUMBER");
		i=Convert.ToInt32(Console.ReadLine());
		for(j=2;j<=i;j++)
		{
			if((i%j)==0)
			int k=j;
			break;
		}
		Console.WriteLine(k);
	}
}
			