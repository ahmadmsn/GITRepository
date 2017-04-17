using System;
class power
{
	public static void Main()
	{
		int e;
		int result;
		for(int i=0;i<10;i++)
		{
			result=1;
			e=i;

			while(e>0)
			{
				result*=2;
				e--;
			}
			Console.WriteLine("2 to the power " +i +"Is "+result);
		}
	}
}