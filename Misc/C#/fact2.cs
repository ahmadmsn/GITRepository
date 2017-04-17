using System;
class factorial
{
	public int number(int n)
	{
		
		int result;
		if(n == 1)
		return 1;
		else
		{
			result = number(n-1) *n;
			return result;
		}
	}
	static void Main(string [] args)
	{
		int i;
		factorial f=new factorial();
		Console.WriteLine("Enter The number which u want factorial");
		i=Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Factorial of " +" "+i+" " +"Is "+f.number(i));
		//Console.WriteLine("Factorial of 5 is"+f.number(5));
		Console.ReadLine();
	}
}
		