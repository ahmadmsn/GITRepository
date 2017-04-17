using System;
namespace Sqaure_Number
{
	class CalculateSqaure
	{
		int number;
		public void Square(int number)
		{
			Console.WriteLine(number);
			number*=number;
			Console.WriteLine(number);
		}
		CalculateSqaure()
		{
			number=10;
			Square(number);
		}
		static void Main(string [] args)
		{
			CalculateSqaure cal = new CalculateSqaure();
			Console.ReadLine();
		}
	}
}