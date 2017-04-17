using System;
class implication
{
	public static void Main()
	{
		bool p=false,q=false;
		int i,j;
		for(i=0;i<2;i++)
		{
			for(j=0;j<2;j++)
			{
				if(i==0) p=true;
				if(i==1) p=false;
				if(j==0) q=true;
				if(j==1) q=false;
			
			Console.WriteLine("P Is "+p+  "  q is  "+q);
			if(!p|q)
			Console.WriteLine(p+" implies "+q+"Is  "+true);
			
			Console.WriteLine();
			}
		}
		
	}
}