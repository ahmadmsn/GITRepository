using System;
class outputfunction
{
	int number;
	int i;
	int j=1;
	public void accept()
	{
		Console.WriteLine("Enter Number");
		number=Convert.ToInt32(Console.ReadLine());
	}
	public void operation()
	{
		
		for(i=1; i>number; i--)
		//Console.Write(i);
		{
			Console.WriteLine(i);
			
			
			for(j=i; j<0; j++)		
			{
				Console.Write(j);
				
			}
			//Console.Write(i);
			//Console.WriteLine(" ");
			//Console.Write(i);			
		}
	}
	public static void Main(string [] args)
	{
		outputfunction c=new outputfunction();
		c.accept();
		c.operation();
	}
}
