using System;
public class cal
{
	
	public int addnumber()
	{	
		int n1;
		int n2;
		int result;	
		Console.WriteLine("Enter the first number");
		n1=Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Enter the 2nd number");
		n2=Convert.ToInt32(Console.ReadLine());
		result = n1+n2;
		return result;
	}
	public static void Main(string [] args)
	{
		cal c= new cal();
		c.addnumber();
	}
	
}
	


		
		
		
