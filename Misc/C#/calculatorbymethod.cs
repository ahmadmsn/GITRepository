using System;
class calculatorbymethod
{
	public static int result;
	public int addnumber()
	{
		int n1;
		int n2;
		Console.WriteLine("Enter the first number");
		n1=Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Enter the 2nd number");
		n2=Convert.ToInt32(Console.ReadLine());
		result = n1+n2;
		return result;
	}
	public int subtractnumber()
	{
		int n1;
		 int n2;
		
		Console.WriteLine("Enter the first number");
		n1=Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Enter the 2nd number");
		n2=Convert.ToInt32(Console.ReadLine());
		result = n1-n2;
		return result;
	}
	public static void Main(string [] args)
	{
		calculatorbymethod c= new calculatorbymethod();
		int result=0;
		int option;
		Console.WriteLine("Main Menu");
		Console.WriteLine("1.Addition");
		Console.WriteLine("2.Subtraction");
		option=Convert.ToInt32(Console.ReadLine());
		if(option==1)
		result=c.addnumber();
		Console.WriteLine(result);
		

		/*switch(option)
		{
			case 1:
			c.addnumber();
			break;
			case 2:
			c.subtractnumber();
			break;
			default:
			Console.WriteLine("Invalid Option");
			break;	
		}*/
		Console.ReadLine();
	}
	
}

		
		
		
