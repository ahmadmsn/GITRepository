using System;
namespace OperatorOverload
{
	struct NumberCount
	{
		public int i;
		public NumberCount(int initval)
		{
			this.i=initval;
		}
		public static NumberCount operator ++(NumberCount arg)
		{
			arg.i++;
			return arg;
		}	
	}
	class TestClass
	{
		static void Main(string [] args)
		{
			NumberCount Count1=new NumberCount(1);
			NumberCount Count2=Count1++;
			Console.WriteLine(Count1.i);
			Console.WriteLine(Count2.i);
			Count2=++Count1;
			
			Console.WriteLine(Count1.i);
			Console.WriteLine(Count2.i);
			Console.ReadLine();
		}
	}
}
			