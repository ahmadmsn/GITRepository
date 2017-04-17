using System;
namespace Calculation
{
	class calculate
	{
		int num1,num2;
		int result;
		char option;
		
		public void enternumber()
		{
			Console.WriteLine("Enter 1st Numnber : {0}", num1);
			num1=Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Enter 2nd Numnber : {0}", num2);
			num2=Convert.ToInt32(Console.ReadLine());	

			Console.WriteLine("Enter Option what you want to do");
			Console.WriteLine("1.Addition");
			Console.WriteLine("2.Subtraction");
			Console.WriteLine("3.Multiplication");
			Console.WriteLine("4.Division");

			option = Convert.ToChar(Console.ReadLine());
			
			switch (option)
			{
				case '1':
					result=num1+num2;
					Console.WriteLine("the result of addition is :{0}", result);
				break;
				case '2':
					result=num1-num2;
					Console.WriteLine("the result of subtraction is :{0}", result);
				break;
				case '3':
					result=num1*num2;
					Console.WriteLine("the result of multiplication is :{0}", result);
				break;
				case '4':
					result=num1/num2;
					Console.WriteLine("the result of division is :{0}", result);
				break;
				default:
					Console.WriteLine("Invalid Option");
				break;
			}
			Console.ReadLine();
		}
	}
	class calculator
	{
		static void Main(string [] args)
		{
			calculate c1=new calculate();
			c1.enternumber();
		}
	}
}
					