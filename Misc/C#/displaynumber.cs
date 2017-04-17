using System;
class check
{
	int number;
	int i;
	int j;
	public void accept()
	{
		Console.WriteLine("Enter Number");
		number=Convert.ToInt32(Console.ReadLine());
	}
	public void operation()
	{
		
		for(i=1; i<=number; i++)
		{
			//Console.Write(i);
			for(j=1; j<=i; j++)
			{
				Console.Write(j);
			}
			Console.WriteLine("\n");
			//Console.Write(j);			
		}
	}
	public static void Main(string [] args)
	{
		check c=new check();
		c.accept();
		c.operation();
	}
}
