using System;
class sorting
{
	public static void Main()
	{
		int [] number= {55,40,80,65,71};
		int n=number.Length;

		Console.Write("Given List");
		for (int i=0;i<n;i++)
		{
			Console.Write("  "+number[i]);
		}
		Console.WriteLine();
		
		for(int i=0;i<n;i++)
		{
			for(int j=i+1;j<n;j++)
			{
				if(number[i] < number[j])
				{
					int temp=number[i];
					number[i]=number[j];
					number[j]=temp;
				}
			}
		}
		Console.Write("Sorted List");
		for(int i=0;i<n;i++)
		{
			Console.Write("  "+number[i]);
		}
	}
}
		