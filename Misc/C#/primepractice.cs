using System;
class PrimeNumber
{
	int i;
	int temp;	
	public void Accept()
	{
		Console.WriteLine("Enter Number Till u want Prime");
		i=Convert.ToInt32(Console.ReadLine());
	}
	public void operation()
	{	
		for(int j=3; j<=i; j++)
		{
			int counter=0;
			for(int y=2; y<j; y++)
			{
				
				temp=j%y;
				if(temp==0)
				counter++;
			}
			if(counter==0)
			{
				Console.WriteLine(j+"  Is Prime");
			}
		}
	}
}
class dispfunction
{
	public static void Main(string [] args)
	{
		PrimeNumber p=new PrimeNumber();
		p.Accept();
		p.operation();
	}
}		
