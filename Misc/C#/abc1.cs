using System;
class abc1
{
	public static int result;
	public int addnumber(ref int num1, ref int num2)
	{
		result=num1+num2;
		return result;
	}
	public int subtractnumber(ref int num1, ref int num2)
	{
		result=num1-num2;
		return result;
	}
	public int multiplication(ref int num1, ref int num2)
	{
		result=num1*num2;
		return result;
	}
	public int division(ref int num1, ref int num2)
	{
		result=num1/num2;
		return result;
	}
	static void Main(string [] args)
	{
		abc1 t=new abc1();
		int option;
		int number1, number2;
		Console.WriteLine("Main Menu");
		Console.WriteLine("1.Addition");
		Console.WriteLine("2.Subtraction");
		Console.WriteLine("3.multiplication");
		Console.WriteLine("4.division");
		Console.WriteLine("Enter Yr Option");
		option=Convert.ToInt32(Console.ReadLine());

		Console.WriteLine("Enter First Number");
		number1=Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Enter The 2nd Number");
		number2=Convert.ToInt32(Console.ReadLine());

		
		switch(option)
		{
			case 1:
			result=t.addnumber(ref number1, ref number2);
			Console.WriteLine(result);			
			break;
			case 2:
			result=t.subtractnumber(ref number1, ref number2);
			Console.WriteLine(result);			
			break;
			case 3:
			result=t.multiplication(ref number1, ref number2);
			Console.WriteLine(result);			
			break;
			case 4:
			result=t.division(ref number1, ref number2);
			Console.WriteLine(result);			
			break;
			default:
			Console.WriteLine("Invalid option");			
			break;
		}
	}
}
			
		
		
		
		
			