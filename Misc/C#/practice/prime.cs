using System;
class primary
{
	
	public static void Main()
	{
		int number;
		int temp=0;
		Console.WriteLine("Enter Number");
		number=Convert.ToInt32(Console.ReadLine());
		for(int i=3; i<=number;i++)
		{
			int counter=0;
			for(int j=2;j<i;j++)
			{
				temp=i%j;
				if(temp==0)
				counter=counter+1;
				//Console.WriteLine("This number Is Not Prime");
			}
			if(counter==0)
			Console.WriteLine(i);
		}
	}
}