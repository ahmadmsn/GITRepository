using System;
class factorial
{
	public int number(int n)
	{
		
		int result;
		//Console.WriteLine("Enter The number which u want factorial");
		//n=Convert.ToInt32(Console.ReadLine());
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
		factorial f=new factorial();
		//int value=f.number();
		//Console.WriteLine("Factorial number is {0}",value);
		Console.WriteLine("Factorial of 4 is"+f.number(4));
		Console.WriteLine("Factorial of 5 is"+f.number(5));
		Console.ReadLine();
	}
}
		